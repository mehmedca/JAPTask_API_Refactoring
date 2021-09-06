using JAP.Common;
using JAP.Core.Entities;
using JAP.Core.Entities.Identity;
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

namespace JAP.Core.Interfaces.IService
{
    public interface IUserService
    {
        Task<AppUserModel> GetUserByIdAsync(string id);
        Task UpdateUserAsync(string id, AppUserUpdateRequest update);
        Task<PagedResult<AppUserModel>> GetPageAsync(AppUserSearchRequest search);
        Task<ICollection<RatingModel>> GetUserRatings(string id);
        Task<PhotoModel> AddUserProfilePhotoAsync(IFormFile file);
    }
}
