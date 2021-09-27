using JAP.Core.Interfaces.IService;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_API.Controllers
{
    [Authorize]
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

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(string id, [FromBody] AppUserUpdateRequest updateRequest)
        {
            await _userService.UpdateUserAsync(id, updateRequest);
            return NoContent();
        }

        [Authorize(Policy = "RequireModeratorRole")]
        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] AppUserSearchRequest search)
        {
            return Ok(await _userService.GetPageAsync(search));
        }


        // USER PHOTO
        [HttpPost("add-photo")]
        public async Task<ActionResult<PhotoModel>> AddPhoto(IFormFile file)
        {
            //Not receiving PhotoInsertRequest instead we'll receive the photo directly without the UserId because we're able to
            // get the UserId from logged user. User will only be able to add a photo if loggedIn == true
            var photoModel = await _userService.AddUserProfilePhotoAsync(file);
            if (photoModel == null) 
                return BadRequest("Problem addding photo");

            return Ok(photoModel);
        }
    }
}
