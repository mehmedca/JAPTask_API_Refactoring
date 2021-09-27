using AutoMapper;
using JAP.Common;
using JAP.Core.Entities;
using JAP.Core.Interfaces;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using JAP.Database.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP.Repository
{
    public class MovieRepository : BaseRepository<MovieModel, MovieSearchRequest, MovieInsertRequest,
        MovieUpdateRequest, Movie>, IMovieRepository
    {
        private readonly IRatingRepository _ratingRepository;
        private readonly IScreeningsRepository _screeningRepository;

        public MovieRepository(JAPContext dbContext,
            IMapper mapper,
            IRatingRepository ratingRepository,
            IScreeningsRepository screeningsRepository,
            ILoggedUser loggedUser
        ) : base(dbContext, mapper, loggedUser)
        {
            _screeningRepository = screeningsRepository;
            _ratingRepository = ratingRepository;
        }

        public async override Task<MovieModel> AddAsync(MovieInsertRequest request)
        {
            var movie = MapMovieEntityFromInsertRequest(request);

            await _context.Movies.AddAsync(movie);

            await SaveChangesAsync();

            //After adding a movie to db we need to add data to ActorsMovies table in order to connect actors who act in that
            // particular movie
            foreach (var item in request.Actors)
            {
                //request.Actors is a list of Actor ids (int) 
                var actor = await _context.Actors.FindAsync(item);
                if(actor != null)
                {
                    await _context.ActorsInMovies.AddAsync(new ActorMovie
                    {
                        ActorId = actor.Id,
                        MovieId = movie.Id
                    });
                }
            }

            await SaveChangesAsync();

            return _mapper.Map<MovieModel>(movie);
        }

        private Movie MapMovieEntityFromInsertRequest(MovieInsertRequest request)
        {
            return new Movie
            {
                DateCreated = DateTime.Now,
                CreatedById = _loggedUser.UserId,
                Description = request.Description,
                MediaType = request.IsTvShow == true ? MediaType.TVSHOW : MediaType.MOVIE,
                ReleaseDate = request.ReleaseDate,
                Title = request.Title
            };
        }

        public async Task AddMovieRatingAsync(RatingInsertRequest request)
        {
            request.RatedById = _loggedUser.UserId;
            if (await _ratingRepository.AddAsync(request) == null) 
                throw new Exception("Something went wrong!");
            
            await SetMovieRatingTotalAsync(request.MovieId);
        }

        public async Task SetMovieRatingTotalAsync(int movieId)
        {
            var movie = await _context.Movies.Where(x => x.Id == movieId).Include(x => x.Ratings).FirstOrDefaultAsync();
            if (movie == null)
                throw new Exception("Movie doesn't exist!");

            double total =  movie.Ratings.Sum(x => x.RatingInt);

            //Set movie rating total, calculate ratings avg
            movie.RatingTotal = total / movie.Ratings.Count;

            await SaveChangesAsync();
        }


        public async Task<ICollection<RatingModel>> GetMovieRatingsAsync(int id)
        {
            var ratings = await _context.Movies.Where(x => x.Id == id)
                .Include(x => x.Ratings).ThenInclude(y => y.RatedByUser).Select(x => x.Ratings)
                .FirstOrDefaultAsync();

            return _mapper.Map<ICollection<RatingModel>>(ratings);
        }

        protected override void AddFilterFromSearchObject(MovieSearchRequest search, ref IQueryable<Movie> query)
        {
            base.AddFilterFromSearchObject(search, ref query);

            //If IsTvShow == 1 means we got a request for tv shows ELSE return movies
            _ = search.IsTvShow == 1 ? query = query.Where(x => x.MediaType == MediaType.TVSHOW) 
                : query = query.Where(x => x.MediaType == MediaType.MOVIE);

            if (!string.IsNullOrWhiteSpace(search.TextualSearch))
            {
                var phraseHit = CheckForPhrases(search, ref query);

                //If we dont have any phrases hit we'll check for other possibilies in description and title
                if(!phraseHit)
                query = query.Where(x => x.Description.ToLower().Contains(search.TextualSearch.ToLower())
                    || x.Title.ToLower().Contains(search.TextualSearch.ToLower()));
            }
        }

        private bool CheckForPhrases(MovieSearchRequest search, ref IQueryable<Movie> query)
        {
            //Split the string into array 
            var searchArray = search.TextualSearch.ToLower().Split(" ");

            //If the array length doesn't match these conditions the search string won't match the desired conditions
            if (searchArray.Length < 2 || searchArray.Length > 4 || searchArray.Length == 3)
                return false;

            //Desired phrase conditions are: "{nrOfStars} stars" - etc. 4 stars, "{before || after} {year}"- etc. before 2012,
            // "at least {nrOfStars} stars" - etc. at least 2 stars, "older than {nrOfYears} years" - etc. Older than 4 years
            if(searchArray.Length == 2)
            {
                //"{before || after} {year}" - etc.before 2012
                if (searchArray[0] == "after" || searchArray[0] == "before")
                {
                    if(int.TryParse(searchArray[1], out int releaseYear))
                    {
                        if (searchArray[0] == "after")
                            query = query.Where(x => x.ReleaseDate.Year > releaseYear);
                        else
                            query = query.Where(x => x.ReleaseDate.Year < releaseYear);

                        return true;
                    }
                }
                //"{nrOfStars} stars" - etc. 4 stars
                if (int.TryParse(searchArray[0], out int starsValue)){
                    if (starsValue < 1 || starsValue > 5)
                        return false;
                    if(searchArray[1].Contains("stars") || searchArray[1].Contains("star"))
                    {
                        query = query.Where(x => x.RatingTotal == starsValue);
                        return true;
                    }
                }
            }
            else if(searchArray.Length == 4)
            {
                //"older than {nrOfYears} years" - etc.Older than 4 years
                if (searchArray[0] == "older")
                {
                    if(int.TryParse(searchArray[2], out int yearsPast))
                    {
                        if (yearsPast < 1)
                            return false;

                        if(search.TextualSearch == $"older than {yearsPast} years"
                            || search.TextualSearch == $"older than {yearsPast} year")
                        {
                            query = query.Where(x => (DateTime.Now.Year - x.ReleaseDate.Year) > yearsPast);
                            return true;
                        }
                    }
                }
                //"at least {nrOfStars} stars" - etc. at least 2 stars
                if (int.TryParse(searchArray[2], out int ratingTotal))
                {
                    if (ratingTotal < 1 || ratingTotal > 5)
                        return false;

                    if (search.TextualSearch == $"at least {ratingTotal} stars"
                        || search.TextualSearch == $"at least {ratingTotal} star")
                    {
                        query = query.Where(x => x.RatingTotal >= ratingTotal);
                        return true;
                    }
                }
            }
            return false;
        }

        public async override Task<PagedResult<MovieModel>> GetPageAsync(MovieSearchRequest search)
        {
            if (search == null)
            {
                search = new MovieSearchRequest();
            }

            PagedResult<MovieModel> result = new PagedResult<MovieModel>();

            var query = _context.Set<Movie>().AsQueryable();
            query = query
                .Include(x => x.CoverImage)
                .Include(x => x.Ratings)
                .Include(x => x.Casts);

            query = query.Where(x => !x.IsDeleted);

            query = await AddFilterAsync(search, query);

            query = query.OrderByDescending(x => x.RatingTotal);

            result.Count = await GetCountAsync(query);

            AddPaging(search, ref query);
            var res = await query.ToListAsync();

            result.Results = _mapper.Map<IReadOnlyList<MovieModel>>(res);

            return result;
        }

        public override async Task<MovieModel> GetByIdAsync(object id)
        {
            var movie = await _context.Movies.Where(x => x.Id == (int)id && !x.IsDeleted)
                .Include(x => x.CoverImage)
                .Include(x => x.Ratings)
                .Include(x => x.Casts).ThenInclude(y => y.Actor).FirstOrDefaultAsync();

            return _mapper.Map<MovieModel>(movie);
        }

        public async Task<ICollection<ScreeningModel>> GetMovieScreeningsAsync(int id)
        {
            return await _screeningRepository.GetMovieScreeningsAsync(id);
        }
    }
}
