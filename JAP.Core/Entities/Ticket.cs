using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public bool IsSold { get; set; } = false;

        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
    }
}
