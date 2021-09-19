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
        Task<ICollection<ProcedureModel>> GetTenMoviesWithMostRatingsAsync();
        Task<ICollection<ProcedureModel>> GetTenMoviesWithMostScreeningsWithDateParamsAsync(TenMoviesWithMostScreeningsSearch request);
        Task<ICollection<ProcedureModel>> GetMoviesWithMostSoldTicketsWithoutRatingsAsync();
    }
}
