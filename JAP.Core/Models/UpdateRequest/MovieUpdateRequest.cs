using JAP.Core.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.UpdateRequest
{
    public class MovieUpdateRequest : CreateUpdateModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? PhotoId { get; set; }
    }
}
