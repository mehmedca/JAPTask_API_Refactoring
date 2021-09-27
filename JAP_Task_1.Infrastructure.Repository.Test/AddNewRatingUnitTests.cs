using AutoMapper;
using JAP.Core.Entities;
using JAP.Core.Interfaces;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
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
    public class AddNewRatingUnitTests
    {
        private JAPContext _context { get; set; }
        private IMapper _mapper { get; set; }
        private Mock<ILoggedUser> mockLoggedUser { get; set; }

        private Movie movie1 { get; set; }
        private RatingInsertRequest failingInsertRequest1 { get; set; }
        private RatingInsertRequest failingInsertRequest2 { get; set; }
        private RatingInsertRequest successfullRequest { get; set; }


        [OneTimeSetUp]
        public async Task Setup()
        {
            var dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("addNewRatingDB");
            _context = new JAPContext(dbContextOptions.Options);

            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(typeof(ModelsToEntitiesProfiles)));
            _mapper = new Mapper(configuration);

            mockLoggedUser = new Mock<ILoggedUser>();

            //Failed because of unexisting movie id
            failingInsertRequest1 = new RatingInsertRequest
            {
                MovieId = 99,
                RatedById = "000-111",
                RatingInt = 5
            };

            //Failed because of bad rating (min 1 - max 5)
            failingInsertRequest2 = new RatingInsertRequest
            {
                MovieId = 1,
                RatedById = "000-111",
                RatingInt = 100
            };

            successfullRequest = new RatingInsertRequest
            {
                MovieId = 1,
                RatedById = "000-111",
                RatingInt = 4
            };

            movie1 = new Movie
            {
                Id = 1,
                Title = "Test title",
                Description = "Test description",
                ReleaseDate = new DateTime(2020, 10, 05),
                RatingTotal = 0
            };
            await _context.Movies.AddAsync(movie1);
            await _context.SaveChangesAsync();
        }


        [Test]
        public void AddMovieRatingAsync_SetRatingToNonExistingMovie_ReturnsNull()
        {
            var ratingRepo = new RatingRepository(_context, _mapper, mockLoggedUser.Object);

            Assert.ThrowsAsync<Exception>(async () => await ratingRepo.AddAsync(failingInsertRequest1));
        }

        [Test]
        public void AddMovieRatingAsync_SetBadRatingValue_ReturnsNull()
        {
            var ratingRepo = new RatingRepository(_context, _mapper, mockLoggedUser.Object);

            Assert.ThrowsAsync<Exception>(async () => await ratingRepo.AddAsync(failingInsertRequest2));
        }

        [Test]
        public async Task AddMovieRatingAsync_SetCorrectRating_RequestSucceeds()
        {
            var ratingRepo = new RatingRepository(_context, _mapper, mockLoggedUser.Object);

            var rating = await ratingRepo.AddAsync(successfullRequest);

            Assert.IsInstanceOf<RatingModel>(rating);
        }
    }
}
