using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models
{
    public class ActorModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public int PhotoId { get; set; }
        public string PhotoUrl { get; set; }
    }
}
