using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models
{
    public class AppUserModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime LastOnline { get; set; }

        public int? PhotoId { get; set; }
        public string PhotoUrl { get; set; }

        public ICollection<RatingModel> UserRatings { get; set; }
        public ICollection<AppUserRoleModel> UserRoles { get; set; }
    }
}
