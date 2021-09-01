using JAP.Common;
using JAP.Database.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_API.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            var appSettingsSection = configuration.GetSection("AuthSettings");
            services.Configure<AuthSettings>(appSettingsSection);

            services.AddDbContext<JAPContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
