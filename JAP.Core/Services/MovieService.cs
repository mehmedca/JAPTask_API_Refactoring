using JAP.Common;
using JAP.Common.Extensions;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Interfaces.IService;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IHttpContextAccessor _httpContext;

        private readonly string userId;
        public MovieService(IMovieRepository movieRepository, IHttpContextAccessor httpContext)
        {
            _movieRepository = movieRepository;
            _httpContext = httpContext;
            userId = _httpContext.HttpContext.User.GetUserId();
        }

        public async Task AddMovieRating(RatingInsertRequest request)
        {
            await _movieRepository.AddMovieRating(request);
        }

        public async Task<MovieModel> GetMovieByIdAsync(int id)
        {
            return await _movieRepository.GetByIdAsync(id);
        }

        public async Task<ICollection<RatingModel>> GetMovieRatings(int id)
        {
            return await _movieRepository.GetMovieRatings(id);
        }

        public async Task<PagedResult<MovieModel>> GetPageAsync(MovieSearchRequest search)
        {
            return await _movieRepository.GetPageAsync(search);
        }

        public async Task<MovieModel> InsertMovieAsync(MovieInsertRequest insert)
        {
            insert.DateCreated = DateTime.Now;
            insert.CreatedById = userId;

            return await _movieRepository.AddAsync(insert);
        }

        public async Task SoftDeleteMovieAsync(int id)
        {
            await _movieRepository.SoftDeleteAsync(id, userId);
        }

        public async Task UpdateMovieAsync(int id, MovieUpdateRequest update)
        {
            update.DateModified = DateTime.Now;
            update.ModifiedById = userId;

            await _movieRepository.UpdateAsync(id, update);
        }
    }
}
