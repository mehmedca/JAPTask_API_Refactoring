using AutoMapper;
using JAP.Common;
using JAP.Core.Entities;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Models;
using JAP.Core.Models.SearchRequest;
using JAP.Database.Context;
using JAP.Mapper;
using JAP.Repository;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP_Task_1.Infrastructure.JAP.Repository.Test
{
    public class MoviesSearchUnitTests
    {
        private JAPContext _context { get; set; }
        private IMapper _mapper { get; set; }
        private Mock<IScreeningsRepository> mockScreeningRepo { get; set; }
        private Mock<IRatingRepository> mockRatingRepo { get; set; }
        private MovieSearchRequest movieSearchRequest { get; set; }
        private MovieSearchRequest tvShowSearchRequest { get; set; }
        private MovieSearchRequest after2015 { get; set; }
        private MovieSearchRequest olderThan5Years { get; set; }
        private MovieSearchRequest atLeast3Start { get; set; }
        private MovieSearchRequest FiveStars { get; set; }
        private MovieSearchRequest CustomTextualSearch { get; set; }
        private MovieSearchRequest deletedMovieSearch { get; set; }


        [OneTimeSetUp]
        public async Task Setup()
        {
            var dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("movieSearchDB");
            _context = new JAPContext(dbContextOptions.Options);

            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(typeof(ModelsToEntitiesProfiles)));
            _mapper = new Mapper(configuration);

            mockScreeningRepo = new Mock<IScreeningsRepository>();
            mockRatingRepo = new Mock<IRatingRepository>();

            movieSearchRequest = new MovieSearchRequest
            {
                IsTvShow = 0
            };
            tvShowSearchRequest = new MovieSearchRequest
            {
                IsTvShow = 1
            };
            after2015 = new MovieSearchRequest
            {
                TextualSearch = "after 2015"
            };
            olderThan5Years = new MovieSearchRequest
            {
                TextualSearch = "older than 5 years"
            };
            FiveStars = new MovieSearchRequest
            {
                TextualSearch = "5 stars"
            };
            atLeast3Start = new MovieSearchRequest
            {
                TextualSearch = "at least 3 stars"
            };
            CustomTextualSearch = new MovieSearchRequest
            {
                TextualSearch = "Shawshank"
            };
            deletedMovieSearch = new MovieSearchRequest
            {
                TextualSearch = "VS Kong"
            };

            //Seed three movies with Release Date in 2010 and avg rating of 5
            for (int i = 70; i < 73; i++)
            {
                await _context.Movies.AddAsync(new Movie
                {
                    Id = i,
                    Title = $"Title {i}",
                    Description = $"Description {i}",
                    ReleaseDate = new DateTime(2010, 10, 05),
                    RatingTotal = 5
                });
            }
            for (int i = 70; i < 73; i++)
            {
                await _context.Ratings.AddAsync(new Rating
                {
                    Id = i,
                    MovieId = i,
                    RatedById = "0000-1111",
                    RatingInt = 5
                });
            }


            //Seed three movies with Release Date in 2020 and avg rating of 4
            for (int i = 73; i < 76; i++)
            {
                await _context.Movies.AddAsync(new Movie
                {
                    Id = i,
                    Title = $"Title {i}",
                    Description = $"Description {i}",
                    ReleaseDate = new DateTime(2020, 10, 05),
                    RatingTotal = 4
                });
            }
            for (int i = 73; i < 76; i++)
            {
                await _context.Ratings.AddAsync(new Rating
                {
                    Id = i,
                    MovieId = i,
                    RatedById = "0000-1111",
                    RatingInt = 4
                });
            }


            //Seed one movie without ratings
            await _context.Movies.AddAsync(new Movie
            {
                Id = 77,
                Title = "Shawshank Redemption",
                Description = "Some test description",
                ReleaseDate = new DateTime(2019, 05, 06)
            });


            //Seed 5 TV Shows
            for (int i = 78; i < 83; i++)
            {
                await _context.Movies.AddAsync(new Movie
                {
                    Id = i,
                    Title = $"Title {i}",
                    Description = $"Description {i}",
                    ReleaseDate = new DateTime(2021, 10, 05),
                    IsTvShow = true,
                    RatingTotal = 4
                });
            }
            for (int i = 78; i < 83; i++)
            {
                await _context.Ratings.AddAsync(new Rating
                {
                    Id = i,
                    MovieId = i,
                    RatedById = "0000-1111",
                    RatingInt = 4
                });
            }


            //Seed one deleted movie
            await _context.Movies.AddAsync(new Movie
            {
                Id = 84,
                Title = "King VS Kong",
                Description = "Some test description",
                ReleaseDate = new DateTime(2021, 05, 06),
                IsDeleted = true
            });


            await _context.SaveChangesAsync();
        }


        [Test]
        public async Task GetPageAsync_SearchForMovies_Returns7Movies()
        {
            var movieRepo = new MovieRepository(_context, _mapper, mockRatingRepo.Object, mockScreeningRepo.Object);

            var moviesList = await movieRepo.GetPageAsync(movieSearchRequest);

            Assert.That(moviesList.Count, Is.EqualTo(7));
        }

        [Test]
        public async Task GetPageAsync_SearchForTvShows_Returns5Shows()
        {
            var movieRepo = new MovieRepository(_context, _mapper, mockRatingRepo.Object, mockScreeningRepo.Object);

            var moviesList = await movieRepo.GetPageAsync(tvShowSearchRequest);

            Assert.That(moviesList.Results.Count, Is.EqualTo(5));
        }

        [Test]
        public async Task GetPageAsync_SearchForMoviesWithReleaseDateAfter2015_Returns4Movies()
        {
            var movieRepo = new MovieRepository(_context, _mapper, mockRatingRepo.Object, mockScreeningRepo.Object);

            var moviesList = await movieRepo.GetPageAsync(after2015);

            Assert.That(moviesList.Results.Count, Is.EqualTo(4));
        }

        [Test]
        public async Task GetPageAsync_SearchForMoviesOlderThan5Years_Returns3Movies()
        {
            var movieRepo = new MovieRepository(_context, _mapper, mockRatingRepo.Object, mockScreeningRepo.Object);

            var moviesList = await movieRepo.GetPageAsync(olderThan5Years);
            
            Assert.That(moviesList.Results.Count, Is.EqualTo(3));
        }

        [Test]
        public async Task GetPageAsync_SearchForMoviesWith5Stars_Returns3Movies()
        {
            var movieRepo = new MovieRepository(_context, _mapper, mockRatingRepo.Object, mockScreeningRepo.Object);

            var moviesList = await movieRepo.GetPageAsync(FiveStars);

            Assert.That(moviesList.Results.Count, Is.EqualTo(3));
        }

        [Test]
        public async Task GetPageAsync_SearchForMoviesWithAtLeast3Stars_Returns6Movies()
        {
            var movieRepo = new MovieRepository(_context, _mapper, mockRatingRepo.Object, mockScreeningRepo.Object);

            var moviesList = await movieRepo.GetPageAsync(atLeast3Start);

            Assert.That(moviesList.Results.Count, Is.EqualTo(6));
        }

        [Test]
        public async Task GetPageAsync_SearchForMoviesWithCustomTextualSearch_ReturnsMovieShawshankRedemption()
        {
            var movieRepo = new MovieRepository(_context, _mapper, mockRatingRepo.Object, mockScreeningRepo.Object);

            var moviesList = await movieRepo.GetPageAsync(CustomTextualSearch);

            Assert.That(moviesList.Results.First().Title.ToLower(), Does.Contain("shawshank"));
        }

        [Test]
        public async Task GetPageAsync_SearchForDeletedMovieByTextualSearch_ReturnsEmptyResult()
        {
            var movieRepo = new MovieRepository(_context, _mapper, mockRatingRepo.Object, mockScreeningRepo.Object);

            var moviesList = await movieRepo.GetPageAsync(deletedMovieSearch);

            Assert.That(moviesList.Results, Is.Empty);
        }
    }
}
