using AutoMapper;
using JAP.Core.Entities;
using JAP.Core.Interfaces.IRepository;
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
    public class CalculateAverageRatingUnitTests
    {
        private JAPContext _context { get; set; }
        private IMapper _mapper { get; set; }
        private Mock<IScreeningsRepository> mockScreeningRepo { get; set; }
        private Mock<IRatingRepository> mockRatingRepo { get; set; }

        private Movie movie1 { get; set; }
        private Movie movie2 { get; set; }


        [OneTimeSetUp]
        public async Task Setup()
        {
            var dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("calculateAverageDB");
            _context = new JAPContext(dbContextOptions.Options);

            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(typeof(ModelsToEntitiesProfiles)));
            _mapper = new Mapper(configuration);

            mockScreeningRepo = new Mock<IScreeningsRepository>();
            mockRatingRepo = new Mock<IRatingRepository>();


            movie1 = new Movie
            {
                Id = 99,
                Title = "Test title",
                Description = "Test description",
                ReleaseDate = new DateTime(2020, 10, 05),
                RatingTotal = 0
            };
            await _context.Movies.AddAsync(movie1);

            for (int i = 55; i < 59; i++)
            {
                await _context.Ratings.AddAsync(new Rating
                {
                    Id = i,
                    MovieId = movie1.Id,
                    RatedById = "0000-1111",
                    RatingInt = i - 53
                });
            }
            await _context.SaveChangesAsync();


            movie2 = new Movie
            {
                Id = 100,
                Title = "Test title",
                Description = "Test description",
                ReleaseDate = new DateTime(2020, 10, 05),
                RatingTotal = 0
            };
            await _context.Movies.AddAsync(movie2);

            for (int i = 60; i < 63; i++)
            {
                await _context.Ratings.AddAsync(new Rating
                {
                    Id = i,
                    MovieId = movie2.Id,
                    RatedById = "0000-1111",
                    RatingInt = 4
                });
            }
            await _context.SaveChangesAsync();
        }



        [Test]
        public void SetMovieRatingTotalAsync_SetRatingToNonExistingMovie_ThrowsException()
        {
            var movieRepo = new MovieRepository(_context, _mapper, mockRatingRepo.Object, mockScreeningRepo.Object);

            Assert.ThrowsAsync<Exception>(async () => await movieRepo.SetMovieRatingTotalAsync(1000));
        }

        [Test]
        public async Task SetMovieRatingTotalAsync_SetFourRatingsToMovie_ResultEqualTo_3_5()
        {
            var movieRepo = new MovieRepository(_context, _mapper, mockRatingRepo.Object, mockScreeningRepo.Object);

            await movieRepo.SetMovieRatingTotalAsync(movie1.Id);

            Assert.That(movie1.RatingTotal, Is.EqualTo(3.5));
        }

        [Test]
        public async Task SetMovieRatingTotalAsync_SetThreeRatingsToMovie_ResultEqualTo_4()
        {
            var movieRepo = new MovieRepository(_context, _mapper, mockRatingRepo.Object, mockScreeningRepo.Object);

            await movieRepo.SetMovieRatingTotalAsync(movie2.Id);

            Assert.That(movie2.RatingTotal, Is.EqualTo(4));
        }
    }
}
