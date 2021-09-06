using AutoMapper;
using JAP.Common;
using JAP.Common.Extensions;
using JAP.Core.Entities;
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
        private readonly IPhotoService _photoService;
        private readonly IHttpContextAccessor _http;

        public ActorRepository(JAPContext dbContext, IMapper mapper, IPhotoService photoService, 
            IHttpContextAccessor http) : base(dbContext, mapper)
        {
            _photoService = photoService;
            _http = http;
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

        public async Task<PhotoModel> AddActorProfilePhotoAsync(PhotoInsertRequest request)
        {
            var result = await _photoService.AddPhotoAsync(request.Photo);

            if (result.Error != null) return null;

            var photo = new Photo
            {
                Url = result.SecureUrl.AbsoluteUri,
                PublicId = result.PublicId
            };

            await _context.AddAsync(photo);
            await SaveChangesAsync();

            var actor = await _context.Actors.FindAsync(request.Id);
            actor.PhotoId = photo.Id;
            actor.DateModified = DateTime.Now;
            actor.ModifiedById = _http.HttpContext.User.GetUserId();

            await SaveChangesAsync();

            return _mapper.Map<PhotoModel>(photo);
        }
    }
}
