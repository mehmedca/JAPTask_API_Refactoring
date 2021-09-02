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
    public class UserService : IUserService
    {
        public Task<IEnumerable<AppUserModel>> GetPageAsync(AppUserSearchRequest search)
        {
            throw new NotImplementedException();
        }

        public Task<AppUserModel> GetUserByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<AppUserModel> InsertUserAsync(AppUserInsertRequest insert)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<AppUserModel> UpdateUserAsync(string id, AppUserUpdateRequest update)
        {
            throw new NotImplementedException();
        }
    }
}
