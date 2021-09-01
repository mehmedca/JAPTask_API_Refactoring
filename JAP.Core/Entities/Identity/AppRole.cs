using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Entities.Identity
{
    public class AppRole : IdentityRole<string>
    {
        [Required]
        [MaxLength(200)]
        public string CreatedById { get; set; }
        public AppUser CreatedBy { get; set; }

        [MaxLength(200)]
        public string ModifiedById { get; set; }
        public AppUser ModifiedBy { get; set; }

        [MaxLength(200)]
        public string DeletedById { get; set; }
        public AppUser DeletedBy { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }

        public bool IsDeleted { get; set; } = false;

        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
