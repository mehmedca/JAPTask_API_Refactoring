using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Entities.Identity
{
    public class AppUser : IdentityUser<string>
    {
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; }
        public DateTime LastOnline { get; set; } = DateTime.Now;

        public int PhotoId { get; set; }
        public Photo UserPhoto { get; set; }

        public ICollection<AppUserRole> UserRoles { get; set; }
        public ICollection<Rating> UserRatings { get; set; }

    }
}
