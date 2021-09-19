using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.ProcedureModels
{
    public class ProcedureModel
    {
        //In common with all calls
        public int MovieId { get; set; }
        public string MovieName { get; set; }


        //Specific to ten movies with most ratings
        public int? NumberOfRatings { get; set; } = null;
        public double? MovieRating { get; set; } = null;


        //Specific to ten movies with most screenings
        public int? NumberOfScreenings { get; set; } = null;


        //Specific to Movies with most sold tickets
        public int? TicketsSold { get; set; } = null;
    }
}
