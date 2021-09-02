using AutoMapper;
using JAP.Core.Entities;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using JAP.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Repository
{
    public class RatingRepository : BaseRepository<RatingModel, object, RatingInsertRequest,
        object, Rating>, IRatingRepository
    {
        public RatingRepository(JAPContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

    }
}
