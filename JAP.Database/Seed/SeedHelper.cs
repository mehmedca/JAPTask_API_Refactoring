using JAP.Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Database.Seed
{
    public static class SeedHelper
    {
        public static void SeedDefaultUsersAndRoles(ModelBuilder builder)
        {
            var hasher = new PasswordHasher<AppUser>();

            #region Users 

            builder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = Common.UserIds.ADMIN_ID,
                    FirstName = "Admin",
                    LastName = "Admin",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "P4$$word"),
                    DateCreated = DateTime.Now
                },
                new AppUser
                {
                    Id = Common.UserIds.MODERATOR_ID,
                    FirstName = "Moderator",
                    LastName = "Moderator",
                    UserName = "moderator",
                    NormalizedUserName = "MODERATOR",
                    PasswordHash = hasher.HashPassword(null, "P4$$word"),
                    DateCreated = DateTime.Now
                },
                new AppUser
                {
                    Id = Common.UserIds.USER_ID,
                    FirstName = "User",
                    LastName = "User",
                    UserName = "user",
                    NormalizedUserName = "USER",
                    PasswordHash = hasher.HashPassword(null, "P4$$word"),
                    DateCreated = DateTime.Now
                });

            #endregion Users

            #region Roles

            builder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id = Common.RoleIds.ADMIN_ROLE_ID,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now
                },
                new AppRole
                {
                    Id = Common.RoleIds.MODERATOR_ROLE_ID,
                    Name = "Moderator",
                    NormalizedName = "MODERATOR",
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now
                },
                new AppRole
                {
                    Id = Common.RoleIds.USER_ROLE_ID,
                    Name = "User",
                    NormalizedName = "USER",
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now
                });

            #endregion Roles

            #region UserRoles

            builder.Entity<AppUserRole>().HasData(
                new AppUserRole
                {
                    RoleId = Common.RoleIds.ADMIN_ROLE_ID,
                    UserId = Common.UserIds.ADMIN_ID
                },
                new AppUserRole
                {
                    RoleId = Common.RoleIds.MODERATOR_ROLE_ID,
                    UserId = Common.UserIds.MODERATOR_ID
                },
                new AppUserRole
                {
                    RoleId = Common.RoleIds.USER_ROLE_ID,
                    UserId = Common.UserIds.USER_ID
                });
            #endregion UserRoles
        }

    }
}
