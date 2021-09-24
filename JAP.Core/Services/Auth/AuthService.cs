using AutoMapper;
using JAP.Common;
using JAP.Core.Entities.Identity;
using JAP.Core.Interfaces.IAuth;
using JAP.Core.Models.AuthModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private AuthSettings _authSettings;

        public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenService tokenService,
            IMapper mapper, IOptions<AuthSettings> authSettings)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
            _tokenService = tokenService;
            _authSettings = authSettings.Value;
        }


        public async Task<TokenModel> Login(LoginModel loginModel)
        {
            var user = await _userManager.Users
                .Include(x => x.UserPhoto)
                .SingleOrDefaultAsync(x => x.UserName == loginModel.UserName.ToLower());

            if (user == null) 
                throw new Exception("Username or password invalid!");

            var result = await _signInManager
                .CheckPasswordSignInAsync(user, loginModel.Password, false);

            if (!result.Succeeded)
                throw new Exception("Username or password invalid!");

            return new TokenModel
            {
                Token = await _tokenService.CreateToken(user),
                UserId = user.Id,
                Username = user.UserName,
                ValidTo = DateTime.Now.AddHours(_authSettings.ValidHours),
                PhotoUrl = user.UserPhoto != null ? user.UserPhoto.Url : null
            };
        }

        public async Task<TokenModel> Register(RegisterModel registerModel)
        {
            if (await UserExists(registerModel.UserName)) 
                throw new Exception("Username is taken");

            AppUser user = _mapper.Map<AppUser>(registerModel);

            user.UserName = registerModel.UserName.ToLower();
            user.Id = Guid.NewGuid().ToString();

            var result = await _userManager.CreateAsync(user, registerModel.Password);

            if (!result.Succeeded) 
                throw new Exception(result.Errors.ToString());

            var roleResult = await _userManager.AddToRoleAsync(user, "User");

            if (!roleResult.Succeeded) 
                throw new Exception(result.Errors.ToString());

            return new TokenModel
            {
                Username = user.UserName,
                Token = await _tokenService.CreateToken(user),
                ValidTo = DateTime.Now.AddHours(_authSettings.ValidHours),
                UserId = user.Id
            };
        }

        private async Task<bool> UserExists(string username)
        {
            return await _userManager.Users.AnyAsync(x => x.UserName == username.ToLower());
        }
    }
}
