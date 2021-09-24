using JAP.Core.Interfaces.IService;
using JAP.Core.Models.InsertRequest;
using JAP_Task_1_API.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP.Web.Controllers
{
    public class RatingsController : BaseApiController
    {
        private readonly IRatingService _ratingService;
        public RatingsController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }


        //Get movie ratings
        [HttpGet("get-movie-ratings/{id}")]
        public async Task<IActionResult> GetMovieRatings(int id)
        {
            return Ok(await _ratingService.GetMovieRatingsAsync(id));
        }

        //Add new rating
        [HttpPost]
        public async Task<IActionResult> AddMovieRating(RatingInsertRequest request)
        {
            await _ratingService.InsertRatingAsync(request);
            return Ok();
        }
    }
}
