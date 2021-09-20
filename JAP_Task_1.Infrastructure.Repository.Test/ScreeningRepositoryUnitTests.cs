using AutoMapper;
using JAP.Core.Entities;
using JAP.Core.Interfaces.IRepository;
using JAP.Database.Context;
using JAP.Mapper;
using JAP.Repository;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1.Infrastructure.JAP.Repository.Test
{
    public class ScreeningRepositoryUnitTests
    {
        private JAPContext _context { get; set; }
        private IMapper _mapper{ get; set; }
        private Screening  screeningInThePast { get; set; }
        private Screening  screeningInTheFutureWithAvailableTickets { get; set; }
        private Screening  screeningInTheFutureWithoutTickets { get; set; }
        private Screening  screeningInTheFutureWithTicketsThatAreSold { get; set; }

        [OneTimeSetUp]
        public async Task Setup()
        {
            var dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("screeningRepoDB");
            _context = new JAPContext(dbContextOptions.Options);

            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(typeof(ModelsToEntitiesProfiles)));
            _mapper = new Mapper(configuration);


            screeningInThePast = new Screening
            {
                Id = 1,
                MovieId = 1,
                StartDate = new DateTime(2021, 09, 15, 21, 30, 0),
                EndDate = new DateTime(2021, 09, 15, 23, 30, 0)
            };
            await _context.Screenings.AddAsync(screeningInThePast);
            await _context.SaveChangesAsync();

            for (int i = 0; i < 5; i++)
            {
                await _context.Tickets.AddAsync(new Ticket
                {
                    IsSold = false,
                    Price = i + 5,
                    ScreeningId = 1
                });
            }
            await _context.SaveChangesAsync();


            screeningInTheFutureWithAvailableTickets = new Screening
            {
                Id = 2,
                MovieId = 1,
                StartDate = new DateTime(2021, 11, 10, 21, 30, 0),
                EndDate = new DateTime(2021, 11, 10, 23, 30, 0)
            };
            await _context.Screenings.AddAsync(screeningInTheFutureWithAvailableTickets);
            await _context.SaveChangesAsync();

            for (int i = 0; i < 5; i++)
            {
                await _context.Tickets.AddAsync(new Ticket
                {
                    IsSold = false,
                    Price = i + 5,
                    ScreeningId = 2
                });
            }
            await _context.SaveChangesAsync();


            screeningInTheFutureWithoutTickets = new Screening
            {
                Id = 3,
                MovieId = 1,
                StartDate = new DateTime(2021, 09, 15, 21, 30, 0),
                EndDate = new DateTime(2021, 09, 15, 23, 30, 0)
            };
            await _context.Screenings.AddAsync(screeningInTheFutureWithoutTickets);
            await _context.SaveChangesAsync();


            screeningInTheFutureWithTicketsThatAreSold = new Screening
            {
                Id = 4,
                MovieId = 1,
                StartDate = new DateTime(2021, 11, 10, 21, 30, 0),
                EndDate = new DateTime(2021, 11, 10, 23, 30, 0)
            };
            await _context.Screenings.AddAsync(screeningInTheFutureWithTicketsThatAreSold);
            await _context.SaveChangesAsync();

            for (int i = 0; i < 5; i++)
            {
                await _context.Tickets.AddAsync(new Ticket
                {
                    IsSold = true,
                    Price = i + 5,
                    ScreeningId = 4
                });
            }
            await _context.SaveChangesAsync();
        }

        [Test]
        public void BuyTicketsAsync_TryToBuyTicketForScreeningInThePast_ThrowsException()
        {
            var scrRepo = new ScreeningsRepository(_context, _mapper);

            Assert.ThrowsAsync<Exception>(async () => await scrRepo.BuyTicketAsync(screeningInThePast.Id));
        }

        [Test]
        public void BuyTicketsAsync_TryToBuyTicketForScreeningInTheFutureWithAvailableTickets_ResultPasses()
        {
            var scrRepo = new ScreeningsRepository(_context, _mapper);

            Assert.DoesNotThrowAsync(async () => await scrRepo.BuyTicketAsync(screeningInTheFutureWithAvailableTickets.Id));
        }

        [Test]
        public void BuyTicketsAsync_TryToBuyTicketForScreeningInTheFutureWithoutExistingTickets_ThrowsException()
        {
            var scrRepo = new ScreeningsRepository(_context, _mapper);

            Assert.ThrowsAsync<Exception>(async () => await scrRepo.BuyTicketAsync(screeningInTheFutureWithoutTickets.Id));
        }

        [Test]
        public void BuyTicketsAsync_TryToBuyTicketForScreeningInTheFutureWithSoldOutTickets_ThrowsException()
        {
            var scrRepo = new ScreeningsRepository(_context, _mapper);

            Assert.ThrowsAsync<Exception>(async () => await scrRepo.BuyTicketAsync(screeningInTheFutureWithTicketsThatAreSold.Id));
        }
    }
}