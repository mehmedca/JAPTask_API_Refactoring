using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces
{
    public interface IErrorLoggerService
    {
        Task LogErrorAsync(Exception ex);
    }
}
