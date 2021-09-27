using JAP.Common;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Interfaces.IService;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using System.Threading.Tasks;

namespace JAP.Core.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }


        public async Task<PagedResult<AppRoleModel>> GetPageAsync(AppRoleSearchRequest search)
        {
            return await _roleRepository.GetPageAsync(search);
        }

        public async Task<AppRoleModel> GetRoleByIdAsync(string id)
        {
            return await _roleRepository.GetByIdAsync(id);
        }

        public async Task<AppRoleModel> InsertRoleAsync(AppRoleInsertRequest insert)
        {
            return await _roleRepository.AddAsync(insert);
        }

        public async Task SoftDeleteRoleAsync(string id)
        {
            await _roleRepository.SoftDeleteAsync(id);
        }

        public async Task UpdateRoleAsync(string id, AppRoleUpdateRequest update)
        {
            await _roleRepository.UpdateAsync(id, update);
        }
    }
}
