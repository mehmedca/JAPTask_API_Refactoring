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
    public class Rating
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Range(1,5)]
        public int RatingInt { get; set; }

        [Required]
        public string RatedById { get; set; }
        public AppUser RatedByUser { get; set; }

        [Required]
        public int MovieId { get; set; }
        public Movie RatedMovie { get; set; }
    }
}
