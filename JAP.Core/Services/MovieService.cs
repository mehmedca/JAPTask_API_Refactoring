using JAP.Common;
using JAP.Common.Extensions;
using JAP.Core.Interfaces;
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
        private readonly IPhotoRepository _photoRepository;
        private readonly IScreeningsRepository _screeningsRepository;
        private readonly ILoggedUser _loggedUser;

        public MovieService(IMovieRepository movieRepository, ILoggedUser loggedUser, IPhotoRepository photoRepository, 
            IScreeningsRepository screeningsRepository)
        {
            _movieRepository = movieRepository;
            _photoRepository = photoRepository;
            _screeningsRepository = screeningsRepository;
            _loggedUser = loggedUser;
        }

        public async Task<PhotoModel> AddMovieCoverPhotoAsync(PhotoInsertRequest request)
        {
            var photo = await _photoRepository.AddPhotoAsync(request.Photo);
            if (photo == null) 
                return null;

            var update = new MovieUpdateRequest
            {
                PhotoId = photo.Id
            };

            await UpdateMovieAsync(request.Id, update);

            return photo;
        }

        public async Task AddMovieRatingAsync(RatingInsertRequest request)
        {
            request.RatedById = _loggedUser.UserId;
            await _movieRepository.AddMovieRatingAsync(request);
        }

        public async Task BuyMovieTicketAsync(int screeningId)
        {
            await _screeningsRepository.BuyTicketAsync(screeningId);
        }

        public async Task<MovieModel> GetMovieByIdAsync(int id)
        {
            return await _movieRepository.GetByIdAsync(id);
        }

        public async Task<ICollection<RatingModel>> GetMovieRatingsAsync(int id)
        {
            return await _movieRepository.GetMovieRatingsAsync(id);
        }

        public async Task<ICollection<ScreeningModel>> GetMovieScreeningsAsync(int id)
        {
            return await _movieRepository.GetMovieScreeningsAsync(id);
        }

        public async Task<PagedResult<MovieModel>> GetPageAsync(MovieSearchRequest search)
        {
            return await _movieRepository.GetPageAsync(search);
        }

        public async Task<MovieModel> InsertMovieAsync(MovieInsertRequest insert)
        {
            insert.DateCreated = DateTime.Now;
            insert.CreatedById = _loggedUser.UserId;

            return await _movieRepository.AddAsync(insert);
        }

        public async Task SoftDeleteMovieAsync(int id)
        {
            await _movieRepository.SoftDeleteAsync(id, _loggedUser.UserId);
        }

        public async Task UpdateMovieAsync(int id, MovieUpdateRequest update)
        {
            update.DateModified = DateTime.Now;
            update.ModifiedById = _loggedUser.UserId;

            await _movieRepository.UpdateAsync(id, update);
        }
    }
}
