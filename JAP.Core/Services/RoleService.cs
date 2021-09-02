using JAP.Common.Extensions;
using JAP.Core.Entities.Identity;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Interfaces.IService;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly string userId;

        public RoleService(IRoleRepository roleRepository, RoleManager<AppRole> roleManager, IHttpContextAccessor httpContextAccessor)
        {
            _roleRepository = roleRepository;
            _roleManager = roleManager;
            _httpContextAccessor = httpContextAccessor;

            userId = _httpContextAccessor.HttpContext.User.GetUserId();
        }


        public async Task<IEnumerable<AppRoleModel>> GetPageAsync(AppRoleSearchRequest search)
        {
            return await _roleRepository.GetPageAsync(search);
        }

        public async Task<AppRoleModel> GetRoleByIdAsync(string id)
        {
            return await _roleRepository.GetByIdAsync(id);
        }

        public async Task<AppRoleModel> InsertRoleAsync(AppRoleInsertRequest insert)
        {
            insert.CreatedById = userId;
            insert.DateCreated = DateTime.Now;

            return await _roleRepository.AddAsync(insert);
        }

        public async Task SoftDeleteRoleAsync(string id)
        {
            await _roleRepository.SoftDeleteAsync(id, userId);
        }

        public async Task UpdateRoleAsync(string id, AppRoleUpdateRequest update)
        {
            update.ModifiedById = userId;
            update.DateModified = DateTime.UtcNow;

            await _roleRepository.UpdateAsync(id, update);
        }
    }
}
