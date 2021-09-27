using JAP_Task_1_API.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace JAP.Web.Errors
{
    public class BadRequestError : ApiError
    {
        public BadRequestError() : base(400, HttpStatusCode.BadRequest.ToString())
        {
        }

        public BadRequestError(string message) : base(400, HttpStatusCode.BadRequest.ToString(), message)
        {
        }
    }
}
