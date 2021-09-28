using JAP.Core.Entities.LogErrorEntities;
using JAP.Core.Interfaces;
using JAP.Database.Context;
using JAP.Web.Errors;
using JAP_Task_1_API.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace JAP_Task_1_API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IHostEnvironment _env;
        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger,
            IHostEnvironment env)
        {
            _env = env;
            _logger = logger;
            _next = next;
        }

        // Since we can only inject Singleton services in Middleware through DI in constructor, I exploited the Middleware's
        // InvokeAsync method which allowed me to get the context and ILoggedUser which I then passed to the method below
        // Visit this post for reference ** first comment reply:
        // https://stackoverflow.com/questions/48590579/cannot-resolve-scoped-service-from-root-provider-net-core-2
        public async Task InvokeAsync(HttpContext context, IErrorLoggerService errorService)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                await HandleExceptionAsync(context, ex, errorService);
            }
        }

       
        private async Task HandleExceptionAsync(HttpContext context, Exception ex, IErrorLoggerService errorService)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            // Log the error to db
            await errorService.LogErrorAsync(ex);

            //Check if is development, if true show full error msg, if not return ISE msg
            var response = _env.IsDevelopment()
                ? new InternalServerError(ex.Message)
                : new InternalServerError();

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

            var json = JsonSerializer.Serialize(response, options);

            await context.Response.WriteAsync(json);
        }
    }
}
