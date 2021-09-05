using AutoMapper;
using JAP.Common;
using JAP.Common.Extensions;
using JAP.Core.Entities;
using JAP.Core.Interfaces.IRepository;
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
        private readonly IHttpContextAccessor _http;
        public MovieRepository(JAPContext dbContext, IMapper mapper, IHttpContextAccessor http) : base(dbContext, mapper)
        {
            _http = http;
        }



        public async override Task<MovieModel> AddAsync(MovieInsertRequest entity)
        {
            //In order to leave a rating you have to be logged in so we're getting logged userId from HttpContext.User var
            var userId = _http.HttpContext.User.GetUserId();
            if (string.IsNullOrWhiteSpace(userId)) return null;

            var movie = MapMovieEntityFromInsertRequest(entity);

            movie.CreatedById = userId;
            await _context.Movies.AddAsync(movie);

            await SaveChangesAsync();

            var isUpdated = false;
            foreach (var item in entity.Actors)
            {
                var actor = await _context.Actors.FindAsync(item);
                if(actor != null)
                {
                    isUpdated = true;
                    await _context.ActorsInMovies.AddAsync(new ActorsMovies
                    {
                        ActorId = actor.Id,
                        MovieId = movie.Id
                    });
                }
            }

            if(isUpdated) await SaveChangesAsync();

            return _mapper.Map<MovieModel>(movie);
        }

        private Movie MapMovieEntityFromInsertRequest(MovieInsertRequest entity)
        {
            return new Movie
            {
                DateCreated = DateTime.Now,
                Description = entity.Description,
                IsTvShow = entity.IsTvShow,
                ReleaseDate = entity.ReleaseDate,
                Title = entity.Title
            };
        }

        public async Task AddMovieRating(RatingInsertRequest request)
        {
            var rating = _mapper.Map<Rating>(request);

            //In order to leave a rating you have to be logged in so we're getting logged userId from HttpContext.User var
            var userId = _http.HttpContext.User.GetUserId();
            if (string.IsNullOrWhiteSpace(userId)) return;
            
            rating.RatedById = _http.HttpContext.User.GetUserId();

            _context.Ratings.Add(rating);
            await SaveChangesAsync();

            await SetMovieRatingTotal(request.MovieId);
        }

        private async Task SetMovieRatingTotal(int movieId)
        {
            var movie = await _context.Movies.Where(x => x.Id == movieId).Include(x => x.MovieRatings).FirstOrDefaultAsync();
            double total = 0;
            foreach (var mr in movie.MovieRatings)
            {
                total += mr.RatingInt;
            }
            movie.RatingTotal = total / movie.MovieRatings.Count;

            await SaveChangesAsync();
        }


        public async Task<ICollection<RatingModel>> GetMovieRatings(int id)
        {
            var ratings = await _context.Movies.Where(x => x.Id == id)
                .Include(x => x.MovieRatings).ThenInclude(y => y.RatedByUser).Select(x => x.MovieRatings).FirstOrDefaultAsync();

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
                .Include(x => x.MovieRatings)
                .Include(x => x.Cast).ThenInclude(y => y.Actor).ThenInclude(z => z.ProfileImg);

            query = await AddFilterAsync(search, query);

            query = query.OrderByDescending(x => x.RatingTotal);

            result.Count = await GetCountAsync(query);

            AddPaging(search, ref query);
            var res = await query.ToListAsync();

            result.Results = _mapper.Map<IReadOnlyList<MovieModel>>(res);

            return result;
        }
    }
}
