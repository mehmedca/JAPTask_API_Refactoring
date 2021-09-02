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

namespace JAP.Core.Interfaces.IService
{
    public interface IActorService
    {
        Task<ActorModel> GetActorByIdAsync(int id);
        Task<ActorModel> InsertActorAsync(ActorInsertRequest insert);
        Task<ActorModel> UpdateActorAsync(int id, ActorUpdateRequest update);
        Task<IEnumerable<ActorModel>> GetPageAsync(ActorSearchRequest search);
        Task SoftDeleteActorAsync(int id);
    }
}
