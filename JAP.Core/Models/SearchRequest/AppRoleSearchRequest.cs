using JAP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.SearchRequest
{
    public class AppRoleSearchRequest : BaseSearch
    {
        public string Name { get; set; }
    }
}
