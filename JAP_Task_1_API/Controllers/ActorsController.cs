using JAP.Core.Interfaces.IService;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_API.Controllers
{
    public class ActorsController : BaseApiController
    {
        private readonly IActorService _actorService;

        public ActorsController(IActorService actorService)
        {
            _actorService = actorService;
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _actorService.GetActorByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ActorInsertRequest insertRequest)
        {
            return Ok(await _actorService.InsertActorAsync(insertRequest));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] ActorUpdateRequest updateRequest)
        {
            await _actorService.UpdateActorAsync(id, updateRequest);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] ActorSearchRequest search)
        {
            return Ok(await _actorService.GetPageAsync(search));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _actorService.SoftDeleteActorAsync(id);
            return Ok(true);
        }


        // ACTOR PHOTO
        [HttpPost("add-photo")]
        public async Task<ActionResult<PhotoModel>> AddPhoto(PhotoInsertRequest request)
        {
            //Insert request will contain IFormFile (photo) and Id which will act as MovieId or ActorId depending on the situation
            var photoModel = await _actorService.AddActorProfilePhotoAsync(request);
            if (photoModel == null) return BadRequest("Problem addding photo");

            return Ok(photoModel);
        }
    }
}
