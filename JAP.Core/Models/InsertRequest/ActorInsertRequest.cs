using JAP.Core.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.InsertRequest
{
    public class ActorInsertRequest : CreateUpdateModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
