using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Common
{
    public class BaseSearch
    {
        public BaseSearch()
        {
            Includes = new List<string>();
        }

        public int? PageSize { get; set; }
        public int? Page { get; set; }
        public bool? RetrieveAll { get; set; }
        public string SortBy { get; set; }
        public IList<string> Includes { get; set; }
    }
}
