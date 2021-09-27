using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces
{
    public interface ILoggedUser
    {
        public string UserId { get; }
        public string Username { get; }
    }
}
