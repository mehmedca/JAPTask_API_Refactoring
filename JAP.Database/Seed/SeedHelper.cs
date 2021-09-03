using JAP.Core.Entities;
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

        public static void SeedImagesToDb(ModelBuilder builder)
        {
            builder.Entity<Photo>().HasData(
                //ACTORS
                new Photo
                {
                    Id = -1,
                    PublicId = "johnnydepp_iora25",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676131/johnnydepp_iora25.jpg"
                },
                new Photo
                {
                    Id = -2,
                    PublicId = "angelinajolie_xjbhe7",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676126/angelinajolie_xjbhe7.jpg"
                },
                new Photo
                {
                    Id = -3,
                    PublicId = "tomhanks_hva0vj",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676130/tomhanks_hva0vj.jpg"
                },
                new Photo
                {
                    Id = -4,
                    PublicId = "natalieportman_i6vuot",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676130/natalieportman_i6vuot.jpg"
                },
                new Photo
                {
                    Id = -5,
                    PublicId = "scarlettjohanson_rkcu5u",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676129/scarlettjohanson_rkcu5u.jpg"
                },
                new Photo
                {
                    Id = -6,
                    PublicId = "bradpitt_zo0pcb",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676129/bradpitt_zo0pcb.jpg"
                },

                //MOVIES
                new Photo
                {
                    Id = -7,
                    PublicId = "hitandrun_ezk6zp",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675787/hitandrun_ezk6zp.jpg"
                },
                new Photo
                {
                    Id = -8,
                    PublicId = "thegodfather_aumlac",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675787/thegodfather_aumlac.jpg"
                },
                new Photo
                {
                    Id = -9,
                    PublicId = "suicidesquad_eq8mih",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675786/suicidesquad_eq8mih.jpg"
                },
                new Photo
                {
                    Id = -10,
                    PublicId = "mrandmrssmith_cstx0w",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675786/mrandmrssmith_cstx0w.jpg"
                },
                new Photo
                {
                    Id = -11,
                    PublicId = "darkknight_uxmvzc",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675786/darkknight_uxmvzc.jpg"
                });
        }

        public static void SeedActorsToDb(ModelBuilder builder)
        {
            builder.Entity<Actor>().HasData(
                new Actor
                {
                    Id = -1,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    FirstName = "Johnny",
                    LastName = "Depp",
                    PhotoId = -1
                },
                new Actor
                {
                    Id = -2,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    FirstName = "Angelina",
                    LastName = "Jolie",
                    PhotoId = -2
                },
                new Actor
                {
                    Id = -3,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    FirstName = "Tom",
                    LastName = "Hanks",
                    PhotoId = -3
                },
                new Actor
                {
                    Id = -4,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    FirstName = "Natalie",
                    LastName = "Portman",
                    PhotoId = -4
                },
                new Actor
                {
                    Id = -5,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    FirstName = "Scarlett",
                    LastName = "Johansson",
                    PhotoId = -5
                },
                new Actor
                {
                    Id = -6,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    FirstName = "Brad",
                    LastName = "Pitt",
                    PhotoId = -6
                });
        }

        public static void SeedMoviesToDb(ModelBuilder builder)
        {
            builder.Entity<Movie>().HasData(
                new Movie
                {
                   Id = -1,
                   CreatedById = Common.UserIds.ADMIN_ID,
                   DateCreated = DateTime.Now,
                   PhotoId = -7,
                   Title = "Hit and Run",
                   Description = "A happily married man's life is turned upside down when his wife is killed in a mysterious hit-and-run accident in Tel Aviv.",
                   ReleaseDate = new DateTime(2021, 4, 12)
                },
                new Movie
                {
                    Id = -2,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    PhotoId = -8,
                    Title = "The Godfather",
                    Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                    ReleaseDate = new DateTime(1972, 6, 17)
                },
                new Movie
                {
                    Id = -3,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    PhotoId = -9,
                    Title = "Suicide Squad",
                    Description = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X",
                    ReleaseDate = new DateTime(2021, 1, 11)
                },
                new Movie
                {
                    Id = -4,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    PhotoId = -10,
                    Title = "Mr and Mrs Smith",
                    Description = "Two spies are recruited by an intelligence agency. They pose as a married couple Mr. and Mrs. Smith when they are on their missions.",
                    ReleaseDate = new DateTime(2005, 4, 5)
                },
                new Movie
                {
                    Id = -5,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    PhotoId = -11,
                    Title = "The Dark Knight",
                    Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    ReleaseDate = new DateTime(2008, 11, 12)
                });
        }

        public static void SeedRatingsToDb(ModelBuilder builder)
        {
            builder.Entity<Rating>().HasData(
                new Rating
                {
                    Id = -1,
                    MovieId = -1,
                    RatedById = Common.UserIds.USER_ID,
                    RatingInt = 3
                },
                new Rating
                {
                    Id = -2,
                    MovieId = -1,
                    RatedById = Common.UserIds.USER_ID,
                    RatingInt = 4
                },
                new Rating
                {
                    Id = -3,
                    MovieId = -2,
                    RatedById = Common.UserIds.USER_ID,
                    RatingInt = 5
                },
                new Rating
                {
                    Id = -4,
                    MovieId = -2,
                    RatedById = Common.UserIds.USER_ID,
                    RatingInt = 4
                },
                new Rating
                {
                    Id = -5,
                    MovieId = -3,
                    RatedById = Common.UserIds.USER_ID,
                    RatingInt = 2
                },
                new Rating
                {
                    Id = -6,
                    MovieId = -3,
                    RatedById = Common.UserIds.USER_ID,
                    RatingInt = 4
                }, 
                new Rating
                {
                    Id = -7,
                    MovieId = -4,
                    RatedById = Common.UserIds.USER_ID,
                    RatingInt = 3
                }, 
                new Rating
                {
                    Id = -8,
                    MovieId = -4,
                    RatedById = Common.UserIds.USER_ID,
                    RatingInt = 5
                }, 
                new Rating
                {
                    Id = -9,
                    MovieId = -5,
                    RatedById = Common.UserIds.USER_ID,
                    RatingInt = 2
                }, 
                new Rating
                {
                    Id = -10,
                    MovieId = -5,
                    RatedById = Common.UserIds.USER_ID,
                    RatingInt = 3
                });
        }
    }
}
