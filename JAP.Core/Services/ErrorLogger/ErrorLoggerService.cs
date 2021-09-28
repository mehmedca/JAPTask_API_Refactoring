using JAP.Core.Interfaces;
using JAP.Core.Interfaces.IRepository.ErrorLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Services.ErrorLogger
{
    public class ErrorLoggerService : IErrorLoggerService
    {
        private readonly IErrorLoggerRepository _errorRepository;
        public ErrorLoggerService(IErrorLoggerRepository errorRepository)
        {
            _errorRepository = errorRepository;
        }
        public async Task LogErrorAsync(Exception ex)
        {
            await _errorRepository.LogErrorAsync(ex);
        }
    }
}
