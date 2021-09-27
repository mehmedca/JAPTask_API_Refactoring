using JAP.Core.Entities.LogErrorEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Database.Context
{
    public class LogErrorContext : DbContext
    {
        public LogErrorContext(DbContextOptions<LogErrorContext> context) : base(context) 
        { }

        public DbSet<ErrorLog> ErrorLogs { get; set; }
    }
}
