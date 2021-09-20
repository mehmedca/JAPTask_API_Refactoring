using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models
{
    public class ScreeningModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int MovieId { get; set; }

        public int NumberOfTicketsAvailable { get; set; }
    }
}
