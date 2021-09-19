using JAP.Core.Models.ProcedureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces.IRepository
{
    public interface IReportsRepository
    {
        Task<ICollection<ProcedureModel>> GetTenMoviesWithMostRatingsAsync();
        Task<ICollection<ProcedureModel>> GetTenMoviesWithMostScreeningsWithDateParamsAsync(TenMoviesWithMostScreeningsSearch request);
        Task<ICollection<ProcedureModel>> GetMoviesWithMostSoldTicketsWithoutRatingsAsync();
    }
}
