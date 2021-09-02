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
    public class UsersController : BaseApiController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _userService.GetUserByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AppUserInsertRequest insertRequest)
        {
            return Ok(await _userService.InsertUserAsync(insertRequest));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(string id, [FromBody] AppUserUpdateRequest updateRequest)
        {
            return Ok(await _userService.UpdateUserAsync(id, updateRequest));
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] AppUserSearchRequest search)
        {
            return Ok(await _userService.GetPageAsync(search));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _userService.SoftDeleteUserAsync(id);
            return Ok(true);
        }
    }
}
