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
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _actorService.GetActorByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ActorInsertRequest insertRequest)
        {
            return Ok(await _actorService.InsertActorAsync(insertRequest));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(string id, [FromBody] ActorUpdateRequest updateRequest)
        {
            return Ok(await _actorService.UpdateActorAsync(id, updateRequest));
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] ActorSearchRequest search)
        {
            return Ok(await _actorService.GetPageAsync(search));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _actorService.SoftDeleteActorAsync(id);
            return Ok(true);
        }
    }
}
