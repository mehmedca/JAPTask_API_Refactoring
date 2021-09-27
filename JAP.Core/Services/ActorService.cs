using JAP.Common;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Interfaces.IService;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using System.Threading.Tasks;

namespace JAP.Core.Services
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;
        private readonly IPhotoRepository _photoRepository;

        public ActorService(IActorRepository actorRepository, IPhotoRepository photoRepository)
        {
            _actorRepository = actorRepository;
            _photoRepository = photoRepository;
        }

        public async Task<PhotoModel> AddActorProfilePhotoAsync(PhotoInsertRequest request)
        {
            var photo = await _photoRepository.AddPhotoAsync(request.Photo);
            if (photo == null) 
                return null;
            var update = new ActorUpdateRequest
            {
                PhotoId = photo.Id
            };

            await UpdateActorAsync(request.Id, update);

            return photo;
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
            return await _actorRepository.AddAsync(insert);
        }

        public async Task SoftDeleteActorAsync(int id)
        {
            await _actorRepository.SoftDeleteAsync(id);
        }

        public async Task UpdateActorAsync(int id, ActorUpdateRequest update)
        {
            await _actorRepository.UpdateAsync(id, update);
        }
    }
}
