using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.UpdateRequest;
using JAP.Core.Models.SearchRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JAP.Core.Interfaces.IService;

namespace JAP_Task_1_API.Controllers
{
    public class MoviesController : BaseApiController
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _movieService.GetMovieByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] MovieInsertRequest insertRequest)
        {
            return Ok(await _movieService.InsertMovieAsync(insertRequest));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] MovieUpdateRequest updateRequest)
        {
            await _movieService.UpdateMovieAsync(id, updateRequest);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] MovieSearchRequest search)
        {
            return Ok(await _movieService.GetPageAsync(search));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _movieService.SoftDeleteMovieAsync(id);
            return Ok(true);
        }



        //RATINGS

        //Get movie ratings
        [HttpGet("ratings/{id}")]
        public async Task<IActionResult> GetMovieRatings(int id)
        {
            return Ok(await _movieService.GetMovieRatings(id));
        }

        [HttpPost("add-rating")]
        public async Task<IActionResult> AddMovieRating(RatingInsertRequest request)
        {
            await _movieService.AddMovieRating(request);
            return Ok();
        }


        // MOVIE PHOTO

    }
}
