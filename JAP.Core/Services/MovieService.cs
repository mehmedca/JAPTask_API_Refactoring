using JAP.Common;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Interfaces.IService;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JAP.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IPhotoRepository _photoRepository;
        private readonly IScreeningsRepository _screeningsRepository;

        public MovieService(IMovieRepository movieRepository, IPhotoRepository photoRepository, 
            IScreeningsRepository screeningsRepository)
        {
            _movieRepository = movieRepository;
            _photoRepository = photoRepository;
            _screeningsRepository = screeningsRepository;
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
            return await _movieRepository.AddAsync(insert);
        }

        public async Task SoftDeleteMovieAsync(int id)
        {
            await _movieRepository.SoftDeleteAsync(id);
        }

        public async Task UpdateMovieAsync(int id, MovieUpdateRequest update)
        {
            await _movieRepository.UpdateAsync(id, update);
        }
    }
}
