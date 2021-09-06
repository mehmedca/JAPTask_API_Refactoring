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

namespace JAP.Core.Interfaces.IRepository
{
    public interface IUserRepository : IBaseRepository<AppUserModel, AppUserSearchRequest, object,
        AppUserUpdateRequest, AppUser>
    {
        Task TrackUserActivity(string userId);
        Task<ICollection<Rating>> GetUserRatings(string userId);
        Task<PhotoModel> AddUserProfilePhotoAsync(IFormFile file);
    }
}
