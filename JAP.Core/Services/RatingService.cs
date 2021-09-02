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
        public Task<RatingModel> GetRatingByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RatingModel> InsertRatingAsync(RatingInsertRequest insert)
        {
            throw new NotImplementedException();
        }
    }
}
