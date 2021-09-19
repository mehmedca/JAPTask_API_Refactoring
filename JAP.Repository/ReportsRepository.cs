using AutoMapper;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Models.ProcedureModels;
using JAP.Database.Context;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Repository
{
    public class ReportsRepository : IReportsRepository
    {
        private readonly JAPContext _context;
        public ReportsRepository(JAPContext context)
        {
            _context = context;
        }

        public Task<ICollection<MoviesWithMostSoldTicketsWithoutRatingsModel>> GetMoviesWithMostSoldTicketsWithoutRatings()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<TenMoviesWithMostRatingsModel>> GetTenMoviesWithMostRatingsAsync()
        {
            List<TenMoviesWithMostRatingsModel> listOfManager = new List<TenMoviesWithMostRatingsModel>();

            using (var conn = _context.Database.GetDbConnection())
            {
                await conn.OpenAsync();

                // Passing PostGre SQL Function Name
                var command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetTenMoviesWithTheMostRatings";

                // Execute the query and obtain a result set
                NpgsqlDataReader reader = (NpgsqlDataReader)command.ExecuteReader();

                // Reading from the database rows
                while (await reader.ReadAsync())
                {
                    // Type Casting is required here and it has to be set according to database column data name
                    string movId = reader["Movie ID"].ToString();
                    string movName = reader["Movie Name"].ToString();
                    string nrOfRtngs = reader["Number Of Ratings"].ToString();
                    string movRtng = reader["Movie Rating"].ToString();
                    listOfManager.Add(new TenMoviesWithMostRatingsModel
                    {
                        MovieId = int.Parse(movId),
                        MovieName = movName,
                        NumberOfRatings = int.Parse(nrOfRtngs),
                        MovieRating = double.Parse(movRtng)
                    });
                }

            }
            return listOfManager;
        }

        public Task<ICollection<TenMoviesWithMostScreeningsModel>> GetTenMoviesWithMostScreeningsWithDateParams(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
