using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.BaseModels
{
    public class CreateUpdateModel
    {
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
