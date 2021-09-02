using JAP.Core.Entities.Identity;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces.IRepository
{
    public interface IRoleRepository : IBaseRepository<AppRoleModel, AppRoleSearchRequest, AppRoleInsertRequest, 
        AppRoleUpdateRequest, AppRole>
    {
    }
}
