using JAP.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Entities.Base
{
    public class BaseDeleteEntity : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string DeletedById { get; set; }
        public AppUser DeletedByUser { get; set; }
        public DateTime? DateDeleted { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
