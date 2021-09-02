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
    public class RoleService : IRoleService
    {
        public Task<IEnumerable<AppRoleModel>> GetPageAsync(AppRoleSearchRequest search)
        {
            throw new NotImplementedException();
        }

        public Task<AppRoleModel> GetRoleByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<AppRoleModel> InsertRoleAsync(AppRoleInsertRequest insert)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteRoleAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<AppRoleModel> UpdateRoleAsync(string id, AppRoleUpdateRequest update)
        {
            throw new NotImplementedException();
        }
    }
}
