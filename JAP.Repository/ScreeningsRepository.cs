using AutoMapper;
using JAP.Core.Entities;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Models;
using JAP.Database.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Repository
{
    public class ScreeningsRepository : IScreeningsRepository
    {
        private readonly JAPContext _context;
        private readonly IMapper _mapper;
        public ScreeningsRepository(JAPContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task BuyTicketAsync(int screningId)
        {
            var screening = await _context.Screenings.Include(x => x.Tickets).Where(x => x.Id == screningId && x.StartDate >= DateTime.Now).FirstOrDefaultAsync();
            if (screening == null)
                throw new Exception("There aren't any tickets left!");

            var boughtTicket = screening.Tickets.FirstOrDefault(y => y.IsSold == false);
            if (boughtTicket != null && !boughtTicket.IsSold)
            {
                boughtTicket.IsSold = true;
                await _context.SaveChangesAsync();
            }
            else
                throw new Exception("There aren't any tickets left!");
        }

        public async Task<ICollection<ScreeningModel>> GetMovieScreeningsAsync(int movieId)
        {
            //Return only the screenings that are in the future and have available tickets 
            var screenings = await _context.Screenings.Include(x => x.Tickets).Where(x => x.MovieId == movieId 
            && x.StartDate >= DateTime.Now && x.Tickets
            .Any(c => c.IsSold == false)).ToListAsync();

            var mappedScreenings = _mapper.Map<List<ScreeningModel>>(screenings);
            for (int i = 0; i < screenings.Count; i++)
            {
                //Get the number of available tickets for every screening
                mappedScreenings[i].NumberOfTicketsAvailable = screenings[i].Tickets.Where(x => x.IsSold == false).Count();
            }

            return mappedScreenings;
        }
    }
}
