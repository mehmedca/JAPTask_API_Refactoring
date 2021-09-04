using AutoMapper;
using JAP.Core.Entities;
using JAP.Core.Entities.Identity;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.SearchRequest;
using JAP.Core.Models.UpdateRequest;
using JAP.Database.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Repository
{
    public class UserRepository : BaseRepository<AppUserModel, AppUserSearchRequest, object,
        AppUserUpdateRequest, AppUser>, IUserRepository
    {
        public UserRepository(JAPContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }


        public async Task TrackUserActivity(string userId)
        {
            var user = await _context.Users.Where(x => x.Id == userId).FirstOrDefaultAsync();
            if (user == null) return;

            user.LastOnline = DateTime.Now;
            await _context.SaveChangesAsync();
        }

        protected override void AddFilterFromSearchObject(AppUserSearchRequest search, ref IQueryable<AppUser> query)
        {
            base.AddFilterFromSearchObject(search, ref query);

            //Filter by first name
            if (!string.IsNullOrWhiteSpace(search.FirstName))
                query = query.Where(x => x.FirstName.ToLower() == search.FirstName.ToLower());

            //Filter by last name
            if (!string.IsNullOrWhiteSpace(search.LastName))
                query = query.Where(x => x.LastName.ToLower() == search.LastName.ToLower());

            //Filter by role
            if (!string.IsNullOrWhiteSpace(search.RoleId))
                query = query.Where(x => x.UserRoles.Any(y => y.RoleId == search.RoleId));
        }

        public override async Task<AppUserModel> GetByIdAsync(object id)
        {
            var user = await _context.Users.AsNoTracking().Where(x => x.Id == (string)id)
                .Include(x => x.UserPhoto).Include(y => y.UserRatings).FirstOrDefaultAsync();

            if (user == null) return null;

            return _mapper.Map<AppUserModel>(user);
        }

        protected override async Task<IQueryable<AppUser>> GetAsync(AppUserSearchRequest search)
        {
            var query = _context.Set<AppUser>()
                .Include(x => x.UserRatings).Include(y => y.UserPhoto).AsQueryable();
            AddInclude(search, ref query);
            query = await AddFilterAsync(search, query);
            AddOrder(search, ref query);
            return await Task.FromResult(query);
        }

        public async Task<ICollection<Rating>> GetUserRatings(string userId)
        {
            var user = await _context.Users.Where(x => x.Id == userId).Include(x => x.UserRatings).FirstOrDefaultAsync();
            var userRatings = new List<Rating>();
            for (int i = 0; i < user.UserRatings.Count; i++)
            {
                userRatings.Add(user.UserRatings.GetEnumerator().Current);
            }

            return userRatings;
        }
    }
}
