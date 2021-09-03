using JAP.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces.IAuth
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
