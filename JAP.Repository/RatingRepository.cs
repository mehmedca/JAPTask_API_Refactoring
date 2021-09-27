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
using System.Text;
using System.Threading.Tasks;

namespace JAP.Repository
{
    public class RatingRepository : BaseRepository<RatingModel, BaseSearch, RatingInsertRequest,
        object, Rating>, IRatingRepository
    {
        public RatingRepository(JAPContext dbContext, IMapper mapper, ILoggedUser loggedUser) 
            : base(dbContext, mapper, loggedUser)
        {
        }

        public async Task<ICollection<RatingModel>> GetMovieRatingsAsync(int movieId)
        {
            var ratings = await _context.Ratings.Where(x => x.MovieId == movieId).ToListAsync();
            return _mapper.Map<List<RatingModel>>(ratings);
        }

        public Task<PagedResult<RatingModel>> GetPageAsync(object search)
        {
            throw new NotImplementedException();
        }
    }
}
