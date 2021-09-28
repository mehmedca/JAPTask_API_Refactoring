using JAP.Core.Entities.LogErrorEntities;
using JAP.Core.Interfaces;
using JAP.Core.Interfaces.IRepository.ErrorLogger;
using JAP.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Repository.ErrorLogger
{
    public class ErrorLoggerRepository : IErrorLoggerRepository
    {
        private readonly LogErrorContext _errorContext;
        private readonly ILoggedUser _loggedUser;
        public ErrorLoggerRepository(LogErrorContext errorContext, ILoggedUser loggedUser)
        {
            _errorContext = errorContext;
            _loggedUser = loggedUser;
        }

        public async Task LogErrorAsync(Exception ex)
        {
            var errorLog = new ErrorLog
            {
                ExceptionMessage = ex.Message,
                ExceptionSource = ex?.Source,
                ExceptionType = HttpStatusCode.InternalServerError.ToString(),
                ExceptionCode = (int)HttpStatusCode.InternalServerError,
                ExceptionTrace = ex?.StackTrace,
                LogDate = DateTime.Now,
                UserId = _loggedUser.UserId
            };
            await _errorContext.ErrorLogs.AddAsync(errorLog);

            if(_errorContext.ChangeTracker.HasChanges())
                await _errorContext.SaveChangesAsync();
        }
    }
}
