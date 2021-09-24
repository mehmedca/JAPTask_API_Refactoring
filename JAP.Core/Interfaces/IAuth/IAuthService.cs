using JAP.Core.Models.AuthModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces.IAuth
{
    public interface IAuthService
    {
        Task<TokenModel> Login(LoginModel loginRequest);
        Task<TokenModel> Register(RegisterModel registerRequest);
    }
}
