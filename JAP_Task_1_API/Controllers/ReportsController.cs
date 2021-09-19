using JAP.Core.Interfaces.IService;
using JAP.Core.Models.ProcedureModels;
using JAP.Database.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_API.Controllers
{
    [Authorize(Policy = "RequireAdminRole")]
    public class ReportsController : BaseApiController
    {
        private readonly IReportsService _reportsService;
        public ReportsController(IReportsService reportsService)
        {
            _reportsService = reportsService;
        }


        [HttpGet]
        [Route("get-ten-movies-with-most-ratings")]
        public async Task<IActionResult> GetTenMoviesWithMostRatings()
        {
            var result = await _reportsService.GetTenMoviesWithMostRatingsAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("get-ten-movies-with-most-screenings")]
        public async Task<IActionResult> GetTenMoviesWithMostScreeningsDesc([FromQuery] TenMoviesWithMostScreeningsSearch request)
        {
            var result = await _reportsService.GetTenMoviesWithMostScreeningsWithDateParamsAsync(request);
            return Ok(result);
        }

        [HttpGet]
        [Route("get-movies-with-most-sold-tickets-without-ratings")]
        public async Task<IActionResult> GetMoviesWithMostSoldTicketsWithoutRatings()
        {
            var result = await _reportsService.GetMoviesWithMostSoldTicketsWithoutRatingsAsync();
            return Ok(result);
        }
    }
}
