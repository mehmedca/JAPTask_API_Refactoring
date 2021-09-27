using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.InsertRequest
{
    public class MovieInsertRequest 
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsTvShow { get; set; }

        public List<int> Actors { get; set; }
    }
}
