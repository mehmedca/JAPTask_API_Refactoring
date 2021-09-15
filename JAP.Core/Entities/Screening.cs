using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Entities
{
    public class Screening
    {
        public Screening()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public ICollection<Ticket> Tickets { get; private set; }
    }
}
