using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.BaseModels
{
    public class DeleteModel : CreateUpdateModel
    {
        public string DeletedById { get; set; }
        public string DeletedByUsername { get; set; }
        public DateTime? DateDeleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
