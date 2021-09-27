using JAP.Common.Extensions;
using JAP.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP.Web.Helpers
{
    public class LoggedUser : ILoggedUser
    {
        public string UserId { get; }
        public string Username { get; }

        public LoggedUser(IHttpContextAccessor httpContext)
        {
            if (httpContext == null)
                return;

            UserId = httpContext.HttpContext.User.GetUserId();
            Username = httpContext.HttpContext.User.GetUsername();
        }
    }
}
