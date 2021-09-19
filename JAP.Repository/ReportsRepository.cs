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

        private const string MoviesWithMostSoldTicketsProcedure = "GetMoviesWithMostSoldTicketsWithoutRating";
        private const string TenMoviesWithMostScreeningsProcedure = "GetTenMoviesWithTheMostScreeningsDesc";
        private const string TenMoviesWithMostRatingsProcedure = "GetTenMoviesWithTheMostRatings";

        public ReportsRepository(JAPContext context)
        {
            _context = context;
        }


        private async Task<List<ProcedureModel>> ReadFromDBProcedure(string procName)
        {
            var listOfManager = new List<ProcedureModel>();

            using (var conn = _context.Database.GetDbConnection())
            {
                await conn.OpenAsync();

                // Passing PostGre SQL Function Name
                var command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = $"{procName}";

                // Execute the query and obtain a result set
                NpgsqlDataReader reader = (NpgsqlDataReader)command.ExecuteReader();
                
                // Reading from the database rows
                while (await reader.ReadAsync())
                {
                    // Type Casting is required here and it has to be set according to database column name
                    string movieId = reader["Movie ID"].ToString();
                    string movieName = reader["Movie Name"].ToString();
                    string numberOfRatings = "";
                    string movieRating = "";
                    string ticketsSold = "";

                    ProcedureModel model = new ProcedureModel
                    {
                        MovieId = int.Parse(movieId),
                        MovieName = movieName
                    };

                    switch (procName)
                    {
                        case "GetMoviesWithMostSoldTicketsWithoutRating": 
                            ticketsSold = reader["Tickets Sold"].ToString();
                            model.TicketsSold = int.Parse(ticketsSold);
                            break;

                        case "GetTenMoviesWithTheMostRatings":
                            numberOfRatings = reader["Number Of Ratings"].ToString();
                            movieRating = reader["Movie Rating"].ToString();
                            model.NumberOfRatings = int.Parse(numberOfRatings);
                            model.MovieRating = double.Parse(movieRating);
                            break;
                    }

                    listOfManager.Add(model);
                }
            }
            return listOfManager;
        }
        public async Task<ICollection<ProcedureModel>> GetMoviesWithMostSoldTicketsWithoutRatingsAsync()
        {
            var listOfManager = await ReadFromDBProcedure(MoviesWithMostSoldTicketsProcedure);
            return listOfManager;
        }

        public async Task<ICollection<ProcedureModel>> GetTenMoviesWithMostRatingsAsync()
        {
            var listOfManager = await ReadFromDBProcedure(TenMoviesWithMostRatingsProcedure);
            return listOfManager;
        }

        public async Task<ICollection<ProcedureModel>> GetTenMoviesWithMostScreeningsWithDateParamsAsync(TenMoviesWithMostScreeningsSearch request)
        {
            List<ProcedureModel> listOfManager = new List<ProcedureModel>();

            using (var conn = _context.Database.GetDbConnection())
            {
                conn.Open();

                //Create the command and pass the params
                using (var command =
                    new NpgsqlCommand("SELECT * FROM GetTenMoviesWithTheMostScreeningsDesc(@StartDate, @EndDate); ", (NpgsqlConnection)conn))
                {
                    command.Parameters.AddWithValue("@StartDate", request.StartDate);
                    command.Parameters.AddWithValue("@EndDate", request.EndDate);
                    using (var dr = command.ExecuteReader())
                    {
                        while (dr.HasRows && await dr.ReadAsync())
                        {
                            string movieId = dr["Movie ID"].ToString();
                            string movieName = dr["Movie Name"].ToString();
                            string numberOfScreenings = dr["Number Of Screenings"].ToString();

                            ProcedureModel model = new ProcedureModel
                            {
                                MovieId = int.Parse(movieId),
                                MovieName = movieName,
                                NumberOfScreenings = int.Parse(numberOfScreenings)
                            };

                            listOfManager.Add(model);
                        }
                    }
                }
            }
            return listOfManager;
        }
    }
}
