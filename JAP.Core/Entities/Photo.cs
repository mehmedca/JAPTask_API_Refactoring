using JAP.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Entities
{
    [Table("Photos")]
    public class Photo
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Url { get; set; }

        [Required]
        [MaxLength(200)]
        public string PublicId { get; set; }
    }
}
