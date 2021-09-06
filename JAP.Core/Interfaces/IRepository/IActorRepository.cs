using JAP.Core.Entities;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces.IRepository
{
    public interface IActorRepository : IBaseRepository<ActorModel, ActorSearchRequest, ActorInsertRequest, 
        ActorUpdateRequest, Actor>
    {
        Task<PhotoModel> AddActorProfilePhotoAsync(PhotoInsertRequest request);
    }
}
