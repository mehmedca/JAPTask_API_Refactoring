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
            Cast = new HashSet<Actor>();
            MovieRatings = new HashSet<Rating>();
        }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public int PhotoId { get; set; }
        public Photo CoverImage { get; set; }

        public ICollection<Actor> Cast { get; private set; }
        public ICollection<Rating> MovieRatings { get; private set; }
    }
}
