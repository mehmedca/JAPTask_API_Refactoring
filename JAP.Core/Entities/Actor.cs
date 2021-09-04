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
    public class Actor : BaseDeleteEntity
    {
        public Actor()
        {
            ActedInMovies = new HashSet<ActorsMovies>();
        }


        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        public int PhotoId { get; set; }
        public Photo ProfileImg { get; set; }

        public ICollection<ActorsMovies> ActedInMovies { get; private set; }

    }
}
