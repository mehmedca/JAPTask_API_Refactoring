using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces.IRepository
{
    public interface IPhotoRepository
    {
        Task<PhotoModel> AddPhotoAsync(IFormFile file);
        Task SaveChangesAsync();
    }
}
