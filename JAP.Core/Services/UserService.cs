using AutoMapper;
using JAP.Common;
using JAP.Common.Extensions;
using JAP.Core.Entities.Identity;
using JAP.Core.Interfaces;
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
        private readonly IMapper _mapper;
        private readonly ILoggedUser _loggedUser;

        public UserService(IUserRepository userRepository, UserManager<AppUser> userManager,
            IMapper mapper, IPhotoRepository photoRepository, ILoggedUser loggedUser)
        {
            _userRepository = userRepository;
            _photoRepository = photoRepository;
            _userManager = userManager;
            _mapper = mapper;
            _loggedUser = loggedUser;
        }

        public async Task<PhotoModel> AddUserProfilePhotoAsync(IFormFile file)
        {
            var photo = await _photoRepository.AddPhotoAsync(file);
            if (photo == null) return null;
            var update = new AppUserUpdateRequest
            {
                PhotoId = photo.Id
            };

            await UpdateUserAsync(_loggedUser.UserId, update);

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

            await _userRepository.UpdateAsync(id, update);
        }

    }
}
