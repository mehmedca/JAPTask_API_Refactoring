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
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;
        private readonly IHttpContextAccessor _httpContext;

        private readonly string userId;
        public ActorService(IActorRepository actorRepository, IHttpContextAccessor httpContext)
        {
            _actorRepository = actorRepository;
            _httpContext = httpContext;
            userId = _httpContext.HttpContext.User.GetUserId();
        }

        public async Task<PhotoModel> AddActorProfilePhotoAsync(PhotoInsertRequest request)
        {
            return await _actorRepository.AddActorProfilePhotoAsync(request);
        }

        public async Task<ActorModel> GetActorByIdAsync(int id)
        {
            return await _actorRepository.GetByIdAsync(id);
        }

        public async Task<PagedResult<ActorModel>> GetPageAsync(ActorSearchRequest search)
        {
            return await _actorRepository.GetPageAsync(search);
        }

        public async Task<ActorModel> InsertActorAsync(ActorInsertRequest insert)
        {
            insert.DateCreated = DateTime.Now;
            insert.CreatedById = userId;

            return await _actorRepository.AddAsync(insert);
        }

        public async Task SoftDeleteActorAsync(int id)
        {
            await _actorRepository.SoftDeleteAsync(id, userId);
        }

        public async Task UpdateActorAsync(int id, ActorUpdateRequest update)
        {
            update.DateModified = DateTime.Now;
            update.ModifiedById = userId;

            await _actorRepository.UpdateAsync(id, update);
        }
    }
}
