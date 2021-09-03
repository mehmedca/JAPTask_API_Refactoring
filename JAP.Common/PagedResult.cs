using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Common
{
    public class PagedResult<T>
    {
        public long Count { get; set; }
        public IReadOnlyList<T> Results { get; set; }
    }
}
