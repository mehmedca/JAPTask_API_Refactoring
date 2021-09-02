using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models
{
    public class RatingModel
    {
        public int Id { get; set; }

        public string RatedByUserId { get; set; }
        public string RatedByUserUsername { get; set; }

        public int MovieId { get; set; }
    }
}
