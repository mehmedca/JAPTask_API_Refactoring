using AutoMapper;
using JAP.Common;
using JAP.Core.Entities.Identity;
using JAP.Core.Interfaces.IAuth;
using JAP.Core.Models.AuthModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_API.Controllers
{
    [Route("[controller]")]
    public class AuthController : BaseApiController
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost("login")]
        public async Task<ActionResult<TokenModel>> Login(LoginModel loginModel)
        {
            return await _authService.Login(loginModel);
        }

        [HttpPost("register")]
        public async Task<ActionResult<TokenModel>> Register(RegisterModel registerModel)
        {
            return await _authService.Register(registerModel);
        }
    }
}
