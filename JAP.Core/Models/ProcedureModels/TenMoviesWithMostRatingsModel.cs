using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.ProcedureModels
{
    public class TenMoviesWithMostRatingsModel
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int NumberOfRatings { get; set; }
        public double MovieRating { get; set; }
    }
}
