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
    public class RolesController : BaseApiController
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _roleService.GetRoleByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AppRoleInsertRequest insertRequest)
        {
            return Ok(await _roleService.InsertRoleAsync(insertRequest));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(string id, [FromBody] AppRoleUpdateRequest updateRequest)
        {
            await _roleService.UpdateRoleAsync(id, updateRequest);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] AppRoleSearchRequest search)
        {
            return Ok(await _roleService.GetPageAsync(search));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _roleService.SoftDeleteRoleAsync(id);
            return Ok(true);
        }
    }
}
