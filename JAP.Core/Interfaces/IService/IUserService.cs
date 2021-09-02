using JAP.Core.Entities;
using JAP.Core.Entities.Identity;
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
    public interface IUserService
    {
        Task<AppUserModel> GetUserByIdAsync(string id);
        Task<AppUserModel> InsertUserAsync(AppUserInsertRequest insert);
        Task<AppUserModel> UpdateUserAsync(string id, AppUserUpdateRequest update);
        Task<IEnumerable<AppUserModel>> GetPageAsync(AppUserSearchRequest search);
        Task SoftDeleteUserAsync(string id);
    }
}
