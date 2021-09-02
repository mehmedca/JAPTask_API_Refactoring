using JAP.Core.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.UpdateRequest
{
    public class AppRoleUpdateRequest : CreateUpdateModel
    {
        public string Name { get; set; }
    }
}
