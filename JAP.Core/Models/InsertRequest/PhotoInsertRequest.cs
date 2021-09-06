using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.InsertRequest
{
    public class PhotoInsertRequest
    {
        public IFormFile Photo { get; set; }

        //ActorId || MovieId
        public int Id { get; set; }
    }
}
