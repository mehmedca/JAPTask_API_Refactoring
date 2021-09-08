using JAP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.SearchRequest
{
    public class MovieSearchRequest : BaseSearch
    {
        public string TextualSearch { get; set; }
        public int IsTvShow { get; set; } = 0;
    }
}
