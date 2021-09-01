using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_API.Extensions
{
    public static class CorsExtensions
    {
        public static void SetupCors(this IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("debug", builder =>
            {
                builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            }));
        }
    }
}
