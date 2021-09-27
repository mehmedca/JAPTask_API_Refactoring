using JAP.Core.Entities;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces.IService
{
    public interface IRatingService
    {
        Task<RatingModel> GetRatingByIdAsync(int id);
        Task<ICollection<RatingModel>> GetMovieRatingsAsync(int movieId);
        Task<RatingModel> InsertRatingAsync(RatingInsertRequest insert);
    }
}
