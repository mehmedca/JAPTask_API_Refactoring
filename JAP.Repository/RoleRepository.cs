using AutoMapper;
using JAP.Core.Entities;
using JAP.Core.Entities.Identity;
using JAP.Core.Interfaces;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using JAP.Database.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Repository
{
    public class RoleRepository : BaseRepository<AppRoleModel, AppRoleSearchRequest, AppRoleInsertRequest,
         AppRoleUpdateRequest, AppRole>, IRoleRepository
    {
        private readonly RoleManager<AppRole> _roleManager;
        public RoleRepository(JAPContext dbContext, IMapper mapper, ILoggedUser loggedUser, RoleManager<AppRole> roleManager) 
            : base(dbContext, mapper, loggedUser)
        {
            _roleManager = roleManager;
        }


        public override async Task<AppRoleModel> AddAsync(AppRoleInsertRequest request)
        {
            if (await _roleManager.RoleExistsAsync(request.Name))
                throw new Exception("The role you are trying to add already exists!");

            var mappedRole = _mapper.Map<AppRole>(request);
            mappedRole.CreatedById = _loggedUser.UserId;
            mappedRole.DateCreated = DateTime.Now;
            mappedRole.Id = Guid.NewGuid().ToString();

            IdentityResult result = await _roleManager.CreateAsync(mappedRole);

            if (!result.Succeeded)
                throw new Exception("Something went wrong!");

            var addedRole = await _roleManager.FindByNameAsync(mappedRole.Name);

            return _mapper.Map<AppRoleModel>(addedRole);
        }

        //Override method to add IsDeleted == false check
        protected override async Task<IQueryable<AppRole>> GetAsync(AppRoleSearchRequest search)
        {
            var query = _context.Set<AppRole>().AsQueryable();
            query = query.Where(x => !x.IsDeleted);
            AddInclude(search, ref query);
            query = await AddFilterAsync(search, query);
            AddOrder(search, ref query);
            return await Task.FromResult(query);
        }
    }
}
