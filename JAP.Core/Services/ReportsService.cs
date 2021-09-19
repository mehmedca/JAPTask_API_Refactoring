using JAP.Core.Interfaces.IRepository;
using JAP.Core.Interfaces.IService;
using JAP.Core.Models.ProcedureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Services
{
    public class ReportsService : IReportsService
    {
        private readonly IReportsRepository _reportsRepository;
        public ReportsService(IReportsRepository reportsRepository)
        {
            _reportsRepository = reportsRepository;
        }

        public async Task<ICollection<ProcedureModel>> GetMoviesWithMostSoldTicketsWithoutRatingsAsync()
        {
            return await _reportsRepository.GetMoviesWithMostSoldTicketsWithoutRatingsAsync();
        }

        public async Task<ICollection<ProcedureModel>> GetTenMoviesWithMostRatingsAsync()
        {
            return await _reportsRepository.GetTenMoviesWithMostRatingsAsync();
        }

        public async Task<ICollection<ProcedureModel>> GetTenMoviesWithMostScreeningsWithDateParamsAsync(TenMoviesWithMostScreeningsSearch request)
        {
            return await _reportsRepository.GetTenMoviesWithMostScreeningsWithDateParamsAsync(request);
        }
    }
}
