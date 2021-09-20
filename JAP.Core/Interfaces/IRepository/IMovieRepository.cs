using JAP.Core.Entities;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces.IRepository
{
    public interface IMovieRepository : IBaseRepository<MovieModel, MovieSearchRequest, MovieInsertRequest,
        MovieUpdateRequest, Movie>
    {
        Task<ICollection<RatingModel>> GetMovieRatingsAsync(int id);
        Task AddMovieRatingAsync(RatingInsertRequest request);
        Task<ICollection<ScreeningModel>> GetMovieScreeningsAsync(int id);
    }
}
