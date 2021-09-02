using JAP.Core.Interfaces.IService;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Services
{
    public class ActorService : IActorService
    {
        public Task<ActorModel> GetActorByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ActorModel>> GetPageAsync(ActorSearchRequest search)
        {
            throw new NotImplementedException();
        }

        public Task<ActorModel> InsertActorAsync(ActorInsertRequest insert)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteActorAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActorModel> UpdateActorAsync(int id, ActorUpdateRequest update)
        {
            throw new NotImplementedException();
        }
    }
}
