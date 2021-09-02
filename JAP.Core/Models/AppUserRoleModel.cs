using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models
{
    public class AppUserRoleModel
    {
        public AppUserModel User { get; set; }
        public AppRoleModel Role { get; set; }
    }
}
