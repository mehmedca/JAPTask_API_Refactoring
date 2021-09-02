using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.SearchRequest
{
    public class MovieSearchRequest
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
