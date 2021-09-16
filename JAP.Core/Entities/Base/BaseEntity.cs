using JAP.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Entities.Base
{
    public class BaseEntity 
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string CreatedById { get; set; } = "rOFHG9xvlRKAdXOjUh3J";
        public AppUser CreatedByUser { get; set; }

        [MaxLength(200)]
        public string ModifiedById { get; set; }
        public AppUser ModifiedByUser { get; set; }

        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; }
    }
}
