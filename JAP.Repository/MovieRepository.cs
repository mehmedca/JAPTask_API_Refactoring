using AutoMapper;
using JAP.Common;
using JAP.Core.Entities;
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
            IScreeningsRepository screeningsRepository
        ) : base(dbContext, mapper)
        {
            _screeningRepository = screeningsRepository;
            _ratingRepository = ratingRepository;
        }



        public async override Task<MovieModel> AddAsync(MovieInsertRequest entity)
        {
            var movie = MapMovieEntityFromInsertRequest(entity);

            await _context.Movies.AddAsync(movie);

            await SaveChangesAsync();

            //After adding a movie to db we need to add data to ActorsMovies table in order to connect actors who act in that
            // particular movie
            foreach (var item in entity.Actors)
            {
                //entity.Actors is a list of Actor ids (int) 
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

        private Movie MapMovieEntityFromInsertRequest(MovieInsertRequest entity)
        {
            return new Movie
            {
                DateCreated = entity.DateCreated,
                CreatedById = entity.CreatedById,
                Description = entity.Description,
                MediaType = entity.IsTvShow == true ? MediaType.TVSHOW : MediaType.MOVIE,
                ReleaseDate = entity.ReleaseDate,
                Title = entity.Title
            };
        }

        public async Task AddMovieRatingAsync(RatingInsertRequest request)
        {
            if (await _ratingRepository.AddAsync(request) == null) throw new Exception("Something went wrong!");
            
            await SetMovieRatingTotalAsync(request.MovieId);
        }

        public async Task SetMovieRatingTotalAsync(int movieId)
        {
            var movie = await _context.Movies.Where(x => x.Id == movieId).Include(x => x.Ratings).FirstOrDefaultAsync();
            if (movie == null)
                throw new Exception("Movie doesn't exist!");

            double total =  movie.Ratings.Sum(x => x.RatingInt);

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

            _ = search.IsTvShow == 1 ? query = query.Where(x => x.MediaType == MediaType.TVSHOW) 
                : query = query.Where(x => x.MediaType == MediaType.MOVIE);

            if (!string.IsNullOrWhiteSpace(search.TextualSearch))
            {
                var phraseHit = CheckForPhrases(search, ref query);

                if(!phraseHit)
                query = query.Where(x => x.Description.ToLower().Contains(search.TextualSearch.ToLower())
                    || x.Title.ToLower().Contains(search.TextualSearch.ToLower()));
            }
        }

        private bool CheckForPhrases(MovieSearchRequest search, ref IQueryable<Movie> query)
        {
            switch (search.TextualSearch.ToLower())
            {
                case "5 stars":
                    query = query.Where(x => x.RatingTotal == 5);
                    return true;
                case "at least 3 stars":
                    query = query.Where(x => x.RatingTotal >= 3);
                    return true;
                case "older than 5 years":
                    query = query.Where(x => (DateTime.Now.Year - x.ReleaseDate.Year) > 5);
                    return true;
                case "after 2015":
                    query = query.Where(x => x.ReleaseDate.Year > 2015);
                    return true;
               
                default: return false;
            }
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
            var movie = await _context.Movies.Where(x => x.Id == (int)id)
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
