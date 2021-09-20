using JAP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces.IRepository
{
    public interface IScreeningsRepository
    {
        public Task<ICollection<ScreeningModel>> GetMovieScreeningsAsync(int movieId);
        public Task BuyTicketAsync(int screningId);
    }
}
