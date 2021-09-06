using AutoMapper;
using JAP.Common;
using JAP.Common.Extensions;
using JAP.Core.Entities;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Interfaces.IService;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using JAP.Database.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Repository
{
    public class MovieRepository : BaseRepository<MovieModel, MovieSearchRequest, MovieInsertRequest,
        MovieUpdateRequest, Movie>, IMovieRepository
    {
        private readonly IRatingRepository _ratingRepository;

        public MovieRepository(JAPContext dbContext, IMapper mapper, IHttpContextAccessor http, 
            IRatingRepository ratingRepository) : base(dbContext, mapper)
        {
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
                    await _context.ActorsInMovies.AddAsync(new ActorsMovies
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
                IsTvShow = entity.IsTvShow,
                ReleaseDate = entity.ReleaseDate,
                Title = entity.Title
            };
        }

        public async Task AddMovieRatingAsync(RatingInsertRequest request)
        {
            if (await _ratingRepository.AddAsync(request) == null) return;
            
            await SetMovieRatingTotalAsync(request.MovieId);
        }

        private async Task SetMovieRatingTotalAsync(int movieId)
        {
            var movie = await _context.Movies.Where(x => x.Id == movieId).Include(x => x.MovieRatings).FirstOrDefaultAsync();
            double total =  movie.MovieRatings.Sum(x => x.RatingInt);

            movie.RatingTotal = total / movie.MovieRatings.Count;

            await SaveChangesAsync();
        }


        public async Task<ICollection<RatingModel>> GetMovieRatingsAsync(int id)
        {
            var ratings = await _context.Movies.Where(x => x.Id == id)
                .Include(x => x.MovieRatings).ThenInclude(y => y.RatedByUser).Select(x => x.MovieRatings)
                .FirstOrDefaultAsync();

            return _mapper.Map<ICollection<RatingModel>>(ratings);
        }

        protected override void AddFilterFromSearchObject(MovieSearchRequest search, ref IQueryable<Movie> query)
        {
            base.AddFilterFromSearchObject(search, ref query);

            if (!string.IsNullOrWhiteSpace(search.TextualSearch))
            {
                query = query.Where(x => x.Description.ToLower().Contains(search.TextualSearch.ToLower())
                    || x.Title.ToLower().Contains(search.TextualSearch.ToLower()));
            }
            if (search.ReleaseYear != null)
            {
                query = query.Where(x => x.ReleaseDate.Year == search.ReleaseYear);
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
                .Include(x => x.MovieRatings);

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
                .Include(x => x.MovieRatings)
                .Include(x => x.Cast).ThenInclude(y => y.Actor).FirstOrDefaultAsync();

            return _mapper.Map<MovieModel>(movie);
        }
    }
}
