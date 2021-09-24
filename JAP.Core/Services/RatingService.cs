using JAP.Core.Interfaces.IRepository;
using JAP.Core.Interfaces.IService;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingService(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        public async Task<List<RatingModel>> GetMovieRatingsAsync(int movieId)
        {
            return await _ratingRepository.GetMovieRatingsAsync(movieId);
        }

        public async Task<RatingModel> GetRatingByIdAsync(int id)
        {
            return await _ratingRepository.GetByIdAsync(id);
        }

        public async Task<RatingModel> InsertRatingAsync(RatingInsertRequest insert)
        {
            return await _ratingRepository.AddAsync(insert);
        }
    }
}
