using JAP.Core.Models.ProcedureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces.IService
{
    public interface IReportsService
    {
        Task<ICollection<TenMoviesWithMostRatingsModel>> GetTenMoviesWithMostRatingsAsync();
        Task<ICollection<TenMoviesWithMostScreeningsModel>> GetTenMoviesWithMostScreeningsWithDateParams(DateTime startDate, DateTime endDate);
        Task<ICollection<MoviesWithMostSoldTicketsWithoutRatingsModel>> GetMoviesWithMostSoldTicketsWithoutRatings();
    }
}
