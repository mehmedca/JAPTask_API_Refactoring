using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces.IRepository.ErrorLogger
{
    public interface IErrorLoggerRepository
    {
        Task LogErrorAsync(Exception ex);
    }
}
