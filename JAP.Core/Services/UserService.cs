using AutoMapper;
using JAP.Common;
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
        private readonly IPhotoRepository _photoRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        private readonly string userId;

        public UserService(IUserRepository userRepository, UserManager<AppUser> userManager,
            IHttpContextAccessor httpContextAccessor, IMapper mapper, IPhotoRepository photoRepository)
        {
            _userRepository = userRepository;
            _photoRepository = photoRepository;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            userId = _httpContextAccessor.HttpContext.User.GetUserId();
        }

        public async Task<PhotoModel> AddUserProfilePhotoAsync(IFormFile file)
        {
            var photo = await _photoRepository.AddPhotoAsync(file);
            if (photo == null) return null;
            var update = new AppUserUpdateRequest
            {
                PhotoId = photo.Id
            };

            await UpdateUserAsync(userId, update);

            return photo;
        }

        public async Task<PagedResult<AppUserModel>> GetPageAsync(AppUserSearchRequest search)
        {
            return await _userRepository.GetPageAsync(search);
        }

        public async Task<AppUserModel> GetUserByIdAsync(string id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            return _mapper.Map<AppUserModel>(user);
        }

        public async Task<ICollection<RatingModel>> GetUserRatings(string id)
        {
            var userRatings = await _userRepository.GetUserRatings(id);
            return _mapper.Map<ICollection<RatingModel>>(userRatings);
        }

        public async Task UpdateUserAsync(string id, AppUserUpdateRequest update)
        {
            var user = await _userManager.Users.Include(x => x.UserRoles)
                .ThenInclude(y => y.Role)
                .FirstOrDefaultAsync(x => x.Id == id);

            update.ModifiedById = userId;
            update.DateModified = DateTime.UtcNow;

            await _userRepository.UpdateAsync(id, update);
        }

    }
}
