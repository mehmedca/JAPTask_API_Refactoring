using JAP.Common.Extensions;
using JAP.Core.Interfaces.IRepository;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace JAP_Task_1_API.Helpers
{
    public class LogUserActivity : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var resultContext = await next();

            if (!resultContext.HttpContext.User.Identity.IsAuthenticated) return;

            var userId = resultContext.HttpContext.User.GetUserId();

            var userRepository = resultContext.HttpContext.RequestServices.GetService<IUserRepository>();

            await userRepository.TrackUserActivity(userId);
        }
    }
}
