using JAP.Core.Interfaces.IService;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Services
{
    public class MovieService : IMovieService
    {
        public Task<MovieModel> GetMovieByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieModel>> GetPageAsync(MovieSearchRequest search)
        {
            throw new NotImplementedException();
        }

        public Task<MovieModel> InsertMovieAsync(MovieInsertRequest insert)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteMovieAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MovieModel> UpdateMovieAsync(int id, MovieUpdateRequest update)
        {
            throw new NotImplementedException();
        }
    }
}
