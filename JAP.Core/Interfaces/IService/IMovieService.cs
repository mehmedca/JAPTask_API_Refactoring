using JAP.Common;
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

namespace JAP.Core.Interfaces.IService
{
    public interface IMovieService
    {
        Task<MovieModel> GetMovieByIdAsync(int id);
        Task<MovieModel> InsertMovieAsync(MovieInsertRequest insert);
        Task UpdateMovieAsync(int id, MovieUpdateRequest update);
        Task<PagedResult<MovieModel>> GetPageAsync(MovieSearchRequest search);
        Task SoftDeleteMovieAsync(int id);
        Task<ICollection<RatingModel>> GetMovieRatingsAsync(int id);
        Task AddMovieRatingAsync(RatingInsertRequest request);
        Task<PhotoModel> AddMovieCoverPhotoAsync(PhotoInsertRequest request);
    }
}
