using JAP.Common.Extensions;
using JAP.Core.Entities.Identity;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Interfaces.IService;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IUserRepository userRepository, UserManager<AppUser> userManager, 
            IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }



        public async Task<IEnumerable<AppUserModel>> GetPageAsync(AppUserSearchRequest search)
        {
            return await _userRepository.GetPageAsync(search);
        }

        public async Task<AppUserModel> GetUserByIdAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            return MapUserModelFromUserEntity(user);
        }

        public async Task UpdateUserAsync(string id, AppUserUpdateRequest update)
        {
            var user = await _userManager.Users.Include(x => x.UserRoles)
                .ThenInclude(y => y.Role)
                .FirstOrDefaultAsync(x => x.Id == id);

            update.ModifiedById = _httpContextAccessor.HttpContext.User.GetUserId();
            update.DateModified = DateTime.UtcNow;

            await _userRepository.UpdateAsync(id, update);
        }

        private AppUserModel MapUserModelFromUserEntity(AppUser user)
        {
            if (user == null) return null;

            return new AppUserModel
            {
                Id = user.Id,
                FullName = user.FirstName + " " + user.LastName,
                UserName = user.UserName,
                DateCreated = user.DateCreated,
                PhotoId = user.PhotoId ?? null,
                PhotoUrl = user.UserPhoto.Url ?? null
            };
        }
    }
}
