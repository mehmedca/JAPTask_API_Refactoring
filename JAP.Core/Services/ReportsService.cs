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

        public Task<ICollection<MoviesWithMostSoldTicketsWithoutRatingsModel>> GetMoviesWithMostSoldTicketsWithoutRatings()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<TenMoviesWithMostRatingsModel>> GetTenMoviesWithMostRatingsAsync()
        {
            return await _reportsRepository.GetTenMoviesWithMostRatingsAsync();
        }

        public Task<ICollection<TenMoviesWithMostScreeningsModel>> GetTenMoviesWithMostScreeningsWithDateParams(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
