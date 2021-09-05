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
                new Photo
                {
                    Id = -12,
                    PublicId = "annehathaway_sgrmnh",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630799748/annehathaway_sgrmnh.jpg"
                },
                new Photo
                {
                    Id = -13,
                    PublicId = "denzelwashington_fu9qmb",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630799745/denzelwashington_fu9qmb.jpg"
                },
                new Photo
                {
                    Id = -14,
                    PublicId = "halleberry_zduavw",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630799738/halleberry_zduavw.jpg"
                },
                new Photo
                {
                    Id = -15,
                    PublicId = "willsmith_eua0te",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630799737/willsmith_eua0te.jpg"
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
                },
                new Photo
                {
                    Id = -16,
                    PublicId = "vacationfriends_dbo6hr",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871033/vacationfriends_dbo6hr.jpg"
                },
                new Photo
                {
                    Id = -17,
                    PublicId = "pig_byciwz",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871033/pig_byciwz.jpg"
                },
                new Photo
                {
                    Id = -18,
                    PublicId = "nowayhome_xivojd",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871035/nowayhome_xivojd.jpg"
                },
                new Photo
                {
                    Id = -19,
                    PublicId = "beckett-2021_nco3v7",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871035/beckett-2021_nco3v7.jpg"
                },
                new Photo
                {
                    Id = -20,
                    PublicId = "junglecruise_fzefqf",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871037/junglecruise_fzefqf.jpg"
                },
                new Photo
                {
                    Id = -21,
                    PublicId = "onceuponatimeinhollywood_jymdi7",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871037/onceuponatimeinhollywood_jymdi7.jpg"
                },
                new Photo
                {
                    Id = -22,
                    PublicId = "wrathofman_xv5ufx",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871039/wrathofman_xv5ufx.jpg"
                },

                //SHOWS
                new Photo
                {
                    Id = -23,
                    PublicId = "breakingbad_uxgsek",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872064/breakingbad_uxgsek.jpg"
                },
                new Photo
                {
                    Id = -24,
                    PublicId = "americanhorrorstory_k1w0he",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872066/americanhorrorstory_k1w0he.jpg"
                },
                new Photo
                {
                    Id = -25,
                    PublicId = "friends_dsvbpm",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872066/friends_dsvbpm.jpg"
                },
                new Photo
                {
                    Id = -26,
                    PublicId = "gameofthrones_h0lrog",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872068/gameofthrones_h0lrog.jpg"
                },
                new Photo
                {
                    Id = -27,
                    PublicId = "peakyblinders_jz6bxi",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872070/peakyblinders_jz6bxi.jpg"
                },
                new Photo
                {
                    Id = -28,
                    PublicId = "greys_fczdub",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872074/greys_fczdub.jpg"
                },
                new Photo
                {
                    Id = -29,
                    PublicId = "thesopranos_alr5zq",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872080/thesopranos_alr5zq.jpg"
                },
                new Photo
                {
                    Id = -30,
                    PublicId = "rickandmorty_l5ptrk",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872081/rickandmorty_l5ptrk.jpg"
                },
                new Photo
                {
                    Id = -31,
                    PublicId = "walkingdead_bycpz3",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872085/walkingdead_bycpz3.jpg"
                },
                new Photo
                {
                    Id = -32,
                    PublicId = "titans_hkz342",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872086/titans_hkz342.jpg"
                },
                new Photo
                {
                    Id = -33,
                    PublicId = "see_olpjnm",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872087/see_olpjnm.jpg"
                },
                new Photo
                {
                    Id = -34,
                    PublicId = "brooklynninenine_s2pba3",
                    Url = "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872097/brooklynninenine_s2pba3.jpg"
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
                },
                new Actor
                {
                    Id = -7,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    FirstName = "Anne",
                    LastName = "Hathaway",
                    PhotoId = -12
                },
                new Actor
                {
                    Id = -8,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    FirstName = "Denzel",
                    LastName = "Washington",
                    PhotoId = -13
                },
                new Actor
                {
                    Id = -9,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    FirstName = "Halle",
                    LastName = "Berry",
                    PhotoId = -14
                },
                new Actor
                {
                    Id = -10,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    FirstName = "Will",
                    LastName = "Smith",
                    PhotoId = -15
                });
        }

        public static void SeedMoviesToDb(ModelBuilder builder)
        {
            builder.Entity<Movie>().HasData(
                //MOVIES
                new Movie
                {
                   Id = -1,
                   CreatedById = Common.UserIds.ADMIN_ID,
                   DateCreated = DateTime.Now,
                   PhotoId = -7,
                   Title = "Hit and Run",
                   Description = "A happily married man's life is turned upside down when his wife is killed in a mysterious hit-and-run accident in Tel Aviv.",
                   ReleaseDate = new DateTime(2021, 4, 12),
                   RatingTotal = 4
                },
                new Movie
                {
                    Id = -2,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    PhotoId = -8,
                    Title = "The Godfather",
                    Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                    ReleaseDate = new DateTime(1972, 6, 17),
                    RatingTotal = 4.2
                },
                new Movie
                {
                    Id = -3,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    PhotoId = -9,
                    Title = "Suicide Squad",
                    Description = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X",
                    ReleaseDate = new DateTime(2021, 1, 11),
                    RatingTotal = 4.1
                },
                new Movie
                {
                    Id = -4,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    PhotoId = -10,
                    Title = "Mr and Mrs Smith",
                    Description = "Two spies are recruited by an intelligence agency. They pose as a married couple Mr. and Mrs. Smith when they are on their missions.",
                    ReleaseDate = new DateTime(2005, 4, 5),
                    RatingTotal = 4.7
                },
                new Movie
                {
                    Id = -5,
                    CreatedById = Common.UserIds.ADMIN_ID,
                    DateCreated = DateTime.Now,
                    PhotoId = -11,
                    Title = "The Dark Knight",
                    Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    ReleaseDate = new DateTime(2008, 11, 12),
                    RatingTotal = 5
                },
                 new Movie
                 {
                     Id = -6,
                     CreatedById = Common.UserIds.ADMIN_ID,
                     DateCreated = DateTime.Now,
                     PhotoId = -18,
                     Title = "Spider Man: No Way Home",
                     Description = "For the first time in the cinematic history of Spider-Man, our friendly neighborhood hero is unmasked and no longer able to separate his normal life from the high-stakes of being a Super Hero.",
                     ReleaseDate = new DateTime(2021, 11, 10),
                     RatingTotal = 3
                 },
                  new Movie
                  {
                      Id = -7,
                      CreatedById = Common.UserIds.ADMIN_ID,
                      DateCreated = DateTime.Now,
                      PhotoId = -20,
                      Title = "Jungle Cruise",
                      Description = "Based on Disneyland's theme park ride where a small riverboat takes a group of travelers through a jungle filled with dangerous animals and reptiles but with a supernatural element.",
                      ReleaseDate = new DateTime(2021, 11, 12),
                      RatingTotal = 3.9
                  },
                   new Movie
                   {
                       Id = -8,
                       CreatedById = Common.UserIds.ADMIN_ID,
                       DateCreated = DateTime.Now,
                       PhotoId = -19,
                       Title = "Beckett",
                       Description = "Following a tragic car accident in Greece, an American tourist finds himself at the center of a dangerous political conspiracy and on the run for his life.",
                       ReleaseDate = new DateTime(2021, 10, 9),
                       RatingTotal = 3.8
                   },
                    new Movie
                    {
                        Id = -9,
                        CreatedById = Common.UserIds.ADMIN_ID,
                        DateCreated = DateTime.Now,
                        PhotoId = -16,
                        Title = "Vacation Friends",
                        Description = "A couple meets up with another couple while on vacation in Mexico, but their friendship takes an awkward turn when they get back home.",
                        ReleaseDate = new DateTime(2021, 1, 6),
                        RatingTotal = 3.55
                    },
                     new Movie
                     {
                         Id = -10,
                         CreatedById = Common.UserIds.ADMIN_ID,
                         DateCreated = DateTime.Now,
                         PhotoId = -21,
                         Title = "Once Upon A Time... In Hollywood",
                         Description = "A faded television actor and his stunt double strive to achieve fame and success in the final years of Hollywood's Golden Age in 1969 Los Angeles.",
                         ReleaseDate = new DateTime(2019, 11, 12),
                         RatingTotal = 5
                     },
                      new Movie
                      {
                          Id = -11,
                          CreatedById = Common.UserIds.ADMIN_ID,
                          DateCreated = DateTime.Now,
                          PhotoId = -17,
                          Title = "Pig",
                          Description = "A truffle hunter who lives alone in the Oregonian wilderness must return to his past in Portland in search of his beloved foraging pig after she is kidnapped.",
                          ReleaseDate = new DateTime(2021, 7, 5),
                          RatingTotal = 2.9
                      },
                       new Movie
                       {
                           Id = -12,
                           CreatedById = Common.UserIds.ADMIN_ID,
                           DateCreated = DateTime.Now,
                           PhotoId = -22,
                           Title = "Wrath of Man",
                           Description = "The plot follows H, a cold and mysterious character working at a cash truck company responsible for moving hundreds of millions of dollars around Los Angeles each week.",
                           ReleaseDate = new DateTime(2021, 11, 12),
                           RatingTotal = 4.1
                       },

                        //TV SHOWS
                        new Movie
                        {
                            Id = -13,
                            CreatedById = Common.UserIds.ADMIN_ID,
                            DateCreated = DateTime.Now,
                            PhotoId = -23,
                            Title = "Breaking bad",
                            Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                            ReleaseDate = new DateTime(2008, 11, 12),
                            IsTvShow = true,
                            RatingTotal = 4
                        },
                        new Movie
                        {
                            Id = -14,
                            CreatedById = Common.UserIds.ADMIN_ID,
                            DateCreated = DateTime.Now,
                            PhotoId = -24,
                            Title = "American Horror Story",
                            Description = "An anthology series centering on different characters and locations, including a house with a murderous past, an insane asylum, a witch coven, a freak show circus, a haunted hotel, and much more.",
                            ReleaseDate = new DateTime(2011, 11, 12),
                            IsTvShow = true,
                            RatingTotal = 4.3
                        },
                        new Movie
                        {
                            Id = -15,
                            CreatedById = Common.UserIds.ADMIN_ID,
                            DateCreated = DateTime.Now,
                            PhotoId = -25,
                            Title = "Friends",
                            Description = "Follows the personal and professional lives of six twenty to thirty-something-year-old friends living in Manhattan.",
                            ReleaseDate = new DateTime(1994, 11, 12),
                            IsTvShow = true,
                            RatingTotal = 4.4
                        },
                        new Movie
                        {
                            Id = -16,
                            CreatedById = Common.UserIds.ADMIN_ID,
                            DateCreated = DateTime.Now,
                            PhotoId = -26,
                            Title = "Game of Thrones",
                            Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                            ReleaseDate = new DateTime(2013, 11, 12),
                            IsTvShow = true,
                            RatingTotal = 4.7
                        },
                        new Movie
                        {
                            Id = -17,
                            CreatedById = Common.UserIds.ADMIN_ID,
                            DateCreated = DateTime.Now,
                            PhotoId = -27,
                            Title = "Peaky Blinders",
                            Description = "A gangster family epic set in 1900s England, centering on a gang who sew razor blades in the peaks of their caps, and their fierce boss Tommy Shelby.",
                            ReleaseDate = new DateTime(2013, 11, 12),
                            IsTvShow = true,
                            RatingTotal = 5
                        },
                        new Movie
                        {
                            Id = -18,
                            CreatedById = Common.UserIds.ADMIN_ID,
                            DateCreated = DateTime.Now,
                            PhotoId = -28,
                            Title = "Grey's Anatomy",
                            Description = "A drama centered on the personal and professional lives of five surgical interns and their supervisors.",
                            ReleaseDate = new DateTime(2005, 11, 12),
                            IsTvShow = true,
                            RatingTotal = 3
                        },
                        new Movie
                        {
                            Id = -19,
                            CreatedById = Common.UserIds.ADMIN_ID,
                            DateCreated = DateTime.Now,
                            PhotoId = -29,
                            Title = "The Sopranos",
                            Description = "New Jersey mob boss Tony Soprano deals with personal and professional issues in his home and business life that affect his mental state, leading him to seek professional psychiatric counseling.",
                            ReleaseDate = new DateTime(1999, 11, 12),
                            IsTvShow = true,
                            RatingTotal = 3.1
                        },
                        new Movie
                        {
                            Id = -20,
                            CreatedById = Common.UserIds.ADMIN_ID,
                            DateCreated = DateTime.Now,
                            PhotoId = -30,
                            Title = "Rick and Morty",
                            Description = "An animated series that follows the exploits of a super scientist and his not-so-bright grandson.",
                            ReleaseDate = new DateTime(2013, 11, 12),
                            IsTvShow = true,
                            RatingTotal = 3.3
                        },
                        new Movie
                        {
                            Id = -21,
                            CreatedById = Common.UserIds.ADMIN_ID,
                            DateCreated = DateTime.Now,
                            PhotoId = -31,
                            Title = "Walking Dead",
                            Description = "Sheriff Deputy Rick Grimes wakes up from a coma to learn the world is in ruins and must lead a group of survivors to stay alive.",
                            ReleaseDate = new DateTime(2010, 11, 12),
                            IsTvShow = true,
                            RatingTotal = 3.4
                        },
                        new Movie
                        {
                            Id = -22,
                            CreatedById = Common.UserIds.ADMIN_ID,
                            DateCreated = DateTime.Now,
                            PhotoId = -32,
                            Title = "Titans",
                            Description = "A team of young superheroes combat evil and other perils.",
                            ReleaseDate = new DateTime(2018, 11, 12),
                            IsTvShow = true,
                            RatingTotal = 3.7
                        },
                        new Movie
                        {
                            Id = -23,
                            CreatedById = Common.UserIds.ADMIN_ID,
                            DateCreated = DateTime.Now,
                            PhotoId = -33,
                            Title = "See",
                            Description = "Far in a dystopian future, the human race has lost the sense of sight, and society has had to find new ways to interact, build, hunt, and to survive.",
                            ReleaseDate = new DateTime(2019, 11, 12),
                            IsTvShow = true,
                            RatingTotal = 2.88
                        },
                        new Movie
                        {
                            Id = -24,
                            CreatedById = Common.UserIds.ADMIN_ID,
                            DateCreated = DateTime.Now,
                            PhotoId = -34,
                            Title = "Brooklyn 99",
                            Description = "Comedy series following the exploits of Det. Jake Peralta and his diverse, lovable colleagues as they police the NYPD's 99th Precinct.",
                            ReleaseDate = new DateTime(2013, 11, 12),
                            IsTvShow = true,
                            RatingTotal = 2.9
                        });
        }

        public static void SeedActorsInMovies(ModelBuilder builder)
        {
            builder.Entity<ActorsMovies>().HasData(
                new ActorsMovies
                {
                    Id = -1,
                    MovieId = -1,
                    ActorId = -1
                },
                new ActorsMovies
                {
                    Id = -2,
                    MovieId = -1,
                    ActorId = -2
                },
                new ActorsMovies
                {
                    Id = -3,
                    MovieId = -2,
                    ActorId = -2
                },
                new ActorsMovies
                {
                    Id = -4,
                    MovieId = -2,
                    ActorId = -3
                },
                new ActorsMovies
                {
                    Id = -5,
                    MovieId = -3,
                    ActorId = -1
                },
                new ActorsMovies
                {
                    Id = -6,
                    MovieId = -3,
                    ActorId = -5
                },
                new ActorsMovies
                {
                    Id = -7,
                    MovieId = -4,
                    ActorId = -6
                },
                new ActorsMovies
                {
                    Id = -8,
                    MovieId = -4,
                    ActorId = -7
                },
                new ActorsMovies
                {
                    Id = -9,
                    MovieId = -4,
                    ActorId = -8
                },
                new ActorsMovies
                {
                    Id = -10,
                    MovieId = -5,
                    ActorId = -9
                },
                new ActorsMovies
                {
                    Id = -11,
                    MovieId = -5,
                    ActorId = -10
                },
                new ActorsMovies
                {
                    Id = -12,
                    MovieId = -6,
                    ActorId = -1
                },
                new ActorsMovies
                {
                    Id = -13,
                    MovieId = -6,
                    ActorId = -2
                },
                new ActorsMovies
                {
                    Id = -14,
                    MovieId = -7,
                    ActorId = -3
                },
                new ActorsMovies
                {
                    Id = -15,
                    MovieId = -7,
                    ActorId = -4
                },
                new ActorsMovies
                {
                    Id = -16,
                    MovieId = -8,
                    ActorId = -5
                },
                new ActorsMovies
                {
                    Id = -17,
                    MovieId = -8,
                    ActorId = -6
                },
                new ActorsMovies
                {
                    Id = -18,
                    MovieId = -9,
                    ActorId = -7
                },
                new ActorsMovies
                {
                    Id = -19,
                    MovieId = -9,
                    ActorId = -8
                },
                new ActorsMovies
                {
                    Id = -20,
                    MovieId = -10,
                    ActorId = -9
                },
                new ActorsMovies
                {
                    Id = -21,
                    MovieId = -10,
                    ActorId = -10
                },
                new ActorsMovies
                {
                    Id = -22,
                    MovieId = -11,
                    ActorId = -1
                },
                new ActorsMovies
                {
                    Id = -23,
                    MovieId = -11,
                    ActorId = -2
                },
                new ActorsMovies
                {
                    Id = -24,
                    MovieId = -12,
                    ActorId = -3
                },
                new ActorsMovies
                {
                    Id = -25,
                    MovieId = -12,
                    ActorId = -4
                },
                new ActorsMovies
                {
                    Id = -26,
                    MovieId = -13,
                    ActorId = -5
                },
                new ActorsMovies
                {
                    Id = -27,
                    MovieId = -13,
                    ActorId = -6
                },
                new ActorsMovies
                {
                    Id = -28,
                    MovieId = -14,
                    ActorId = -7
                },
                new ActorsMovies
                {
                    Id = -29,
                    MovieId = -14,
                    ActorId = -8
                },
                new ActorsMovies
                {
                    Id = -30,
                    MovieId = -15,
                    ActorId = -9
                },
                new ActorsMovies
                {
                    Id = -31,
                    MovieId = -15,
                    ActorId = -10
                },
                new ActorsMovies
                {
                    Id = -32,
                    MovieId = -16,
                    ActorId = -3
                },
                new ActorsMovies
                {
                    Id = -33,
                    MovieId = -17,
                    ActorId = -2
                },
                new ActorsMovies
                {
                    Id = -34,
                    MovieId = -17,
                    ActorId = -6
                },
                new ActorsMovies
                {
                    Id = -35,
                    MovieId = -18,
                    ActorId = -9
                },
                new ActorsMovies
                {
                    Id = -36,
                    MovieId = -18,
                    ActorId = -10
                },
                new ActorsMovies
                {
                    Id = -37,
                    MovieId = -19,
                    ActorId = -3
                },
                new ActorsMovies
                {
                    Id = -38,
                    MovieId = -19,
                    ActorId = -5
                },
                new ActorsMovies
                {
                    Id = -39,
                    MovieId = -20,
                    ActorId = -8
                },
                new ActorsMovies
                {
                    Id = -40,
                    MovieId = -20,
                    ActorId = -9
                },
                new ActorsMovies
                {
                    Id = -41,
                    MovieId = -21,
                    ActorId = -2
                },
                new ActorsMovies
                {
                    Id = -42,
                    MovieId = -21,
                    ActorId = -4
                },
                new ActorsMovies
                {
                    Id = -43,
                    MovieId = -22,
                    ActorId = -6
                },
                new ActorsMovies
                {
                    Id = -44,
                    MovieId = -22,
                    ActorId = -7
                },
                new ActorsMovies
                {
                    Id = -45,
                    MovieId = -23,
                    ActorId = -9
                },
                new ActorsMovies
                {
                    Id = -46,
                    MovieId = -23,
                    ActorId = -1
                },
                new ActorsMovies
                {
                    Id = -47,
                    MovieId = -24,
                    ActorId = -2
                },
                new ActorsMovies
                {
                    Id = -48,
                    MovieId = -24,
                    ActorId = -5
                },
                new ActorsMovies
                {
                    Id = -49,
                    MovieId = -22,
                    ActorId = -8
                },
                new ActorsMovies
                {
                    Id = -50,
                    MovieId = -24,
                    ActorId = -9
                },
                new ActorsMovies
                {
                    Id = -51,
                    MovieId = -16,
                    ActorId = -1
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
