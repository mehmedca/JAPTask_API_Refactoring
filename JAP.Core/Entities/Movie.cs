using JAP.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Entities
{
    public class Movie : BaseDeleteEntity
    {
        public Movie()
        {
            Casts = new HashSet<ActorMovie>();
            Ratings = new HashSet<Rating>();
            Screenings = new HashSet<Screening>();
        }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public int? PhotoId { get; set; }
        public Photo CoverImage { get; set; }

        public double RatingTotal { get; set; }
        public bool IsTvShow { get; set; } = false;

        public ICollection<Screening> Screenings { get; private set; }
        public ICollection<ActorMovie> Casts { get; private set; }
        public ICollection<Rating> Ratings { get; private set; }
    }
}
