using AutoMapper;
using JAP.Common;
using JAP.Common.Extensions;
using JAP.Core.Entities;
using JAP.Core.Interfaces;
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
    public class ActorRepository : BaseRepository<ActorModel, ActorSearchRequest, ActorInsertRequest, 
        ActorUpdateRequest, Actor>, IActorRepository
    {
        public ActorRepository(JAPContext dbContext, IMapper mapper, ILoggedUser loggedUser) 
            : base(dbContext, mapper, loggedUser)
        {
        }


        protected override void AddFilterFromSearchObject(ActorSearchRequest search, ref IQueryable<Actor> query)
        {
            base.AddFilterFromSearchObject(search, ref query);

            if (!string.IsNullOrWhiteSpace(search.FirstName))
                query = query.Where(x => x.FirstName.ToLower().Contains(search.FirstName.ToLower()));
            if (!string.IsNullOrWhiteSpace(search.LastName))
                query = query.Where(x => x.LastName.ToLower().Contains(search.LastName.ToLower()));
        }

        public async override Task<PagedResult<ActorModel>> GetPageAsync(ActorSearchRequest search)
        {
            if (search == null)
            {
                search = new ActorSearchRequest();
            }

            PagedResult<ActorModel> result = new PagedResult<ActorModel>();

            var query = _context.Set<Actor>().AsQueryable();
            query = query
                .Include(x => x.ProfileImg);

            query = await AddFilterAsync(search, query);

            query = query.OrderByDescending(x => x.Id);

            result.Count = await GetCountAsync(query);

            AddPaging(search, ref query);
            var res = await query.ToListAsync();

            result.Results = _mapper.Map<IReadOnlyList<ActorModel>>(res);

            return result;
        }
    }
}
