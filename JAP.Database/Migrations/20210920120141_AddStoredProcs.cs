using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class AddStoredProcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                 @"CREATE OR REPLACE FUNCTION GetTenMoviesWithTheMostRatings () 
                    RETURNS TABLE (
                        ""Movie ID"" INT,
                        ""Movie Name"" VARCHAR,
                        ""Number Of Ratings"" BIGINT,
                        ""Movie Rating"" DECIMAL
                )
                AS $$
                BEGIN
                    RETURN QUERY
                    SELECT mov.""Id"" AS ""Movie ID"", mov.""Title"" AS ""Movie name"", COUNT(mov.""Id"") AS ""Number of ratings"",
		                ROUND(AVG(rat.""RatingInt""), 2) AS ""Movie rating""

                    FROM public.""Movies"" AS ""mov"" INNER JOIN public.""Ratings"" AS ""rat""
		                ON mov.""Id"" = rat.""MovieId""

                    WHERE mov.""IsTvShow"" = false

                    GROUP BY mov.""Id"", mov.""Title""

                    ORDER BY COUNT(rat.""Id"") DESC
                    LIMIT 10;
                        END; $$ 

                LANGUAGE 'plpgsql';"
                );

            migrationBuilder.Sql(
                @"CREATE OR REPLACE FUNCTION GetTenMoviesWithTheMostScreeningsDesc (StartDate timestamp, EndDate timestamp) 
                        RETURNS TABLE (
                            ""Movie ID"" INT,
                            ""Movie Name"" VARCHAR,
                            ""Number Of Screenings"" BIGINT
                    )
                    AS $$
                    BEGIN
                        RETURN QUERY
                        SELECT mov.""Id"" AS ""Movie ID"", mov.""Title"" AS ""Movie name"", COUNT(scr.""Id"") AS ""Number of screenings""

                        FROM public.""Movies"" AS ""mov"" INNER JOIN public.""Screenings"" AS ""scr""
		                    ON mov.""Id"" = scr.""MovieId""

                        WHERE mov.""IsTvShow"" = false AND scr.""StartDate"" >= StartDate AND scr.""EndDate"" <= EndDate
                        GROUP BY mov.""Id"", mov.""Title""

                        ORDER BY COUNT(scr.""Id"") DESC
                        LIMIT 10;
                            END; $$ 

                    LANGUAGE 'plpgsql';
                "
                );

            migrationBuilder.Sql(
                @"
                    CREATE OR REPLACE FUNCTION GetMoviesWithMostSoldTicketsWithoutRating () 
                    RETURNS TABLE (
                        ""Movie ID"" INT,
                        ""Movie Name"" VARCHAR,
                        ""Tickets Sold"" BIGINT
                )
                AS $$
                BEGIN
                    RETURN QUERY
                    SELECT mov.""Id"" as ""Movie ID"", mov.""Title"" as ""Movie name"", COUNT(tick.""Id"") as ""Tickets sold""

                    FROM public.""Movies"" as ""mov"" INNER JOIN public.""Screenings"" as ""scr"" 
		                 ON mov.""Id"" = scr.""MovieId"" INNER JOIN public.""Tickets"" as ""tick"" 
		                 ON scr.""Id"" = tick.""ScreeningId""

                    WHERE mov.""IsTvShow"" = false AND tick.""IsSold"" = true AND mov.""RatingTotal"" = 0

                    GROUP BY mov.""Id"", mov.""Title""

                    ORDER BY COUNT(tick.""Id"") DESC;
                END; $$ 

                LANGUAGE 'plpgsql';
                "
                );

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "de88591e-e3c5-4af0-88a3-548544c53127", new DateTime(2021, 9, 20, 14, 1, 40, 477, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "00a7028a-5009-45f8-b4e4-7f0549e50ed9", new DateTime(2021, 9, 20, 14, 1, 40, 477, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "1130fd9c-9da4-43e1-a06e-9288309932df", new DateTime(2021, 9, 20, 14, 1, 40, 477, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "ab31e2c8-eace-4d94-8ec7-bdc2a78f26a8", new DateTime(2021, 9, 20, 14, 1, 40, 476, DateTimeKind.Local).AddTicks(5974), new DateTime(2021, 9, 20, 14, 1, 40, 469, DateTimeKind.Local).AddTicks(1897), "AQAAAAEAACcQAAAAEHZOZaQlwRXUfX4oGeWL0rNlz3tOm0XRJouu7RJUXkKxb0KQJ9ebe9PKt+3Dy8UYmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "caa7a3a9-ea9a-48f6-9421-1ff36724edbb", new DateTime(2021, 9, 20, 14, 1, 40, 469, DateTimeKind.Local).AddTicks(1881), new DateTime(2021, 9, 20, 14, 1, 40, 461, DateTimeKind.Local).AddTicks(7419), "AQAAAAEAACcQAAAAEO3N6d4JDZvAsQAiMiCdLVVY1hg7Tg8+E/x+zphJdKUrRzcbEQf8detY+7ZVhM4H4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "ebb3139e-5ddd-4be6-b1a1-fe2520b326c2", new DateTime(2021, 9, 20, 14, 1, 40, 461, DateTimeKind.Local).AddTicks(6845), new DateTime(2021, 9, 20, 14, 1, 40, 451, DateTimeKind.Local).AddTicks(9549), "AQAAAAEAACcQAAAAEPy6OP6QQm7QO03G+WYfg07aJa2zZOn5d4QEchC6E8wscWjM0TPEY1wjmXo7WKXT5w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(
                @"drop function if exists GetTenMoviesWithTheMostRatings ()"
                );

            migrationBuilder.Sql(
                @"drop function if exists GetTenMoviesWithTheMostScreeningsDesc (StartDate timestamp, EndDate timestamp)"
                );

            migrationBuilder.Sql(
                @"drop function if exists GetMoviesWithMostSoldTicketsWithoutRating  ()"
                );

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "351a473f-98f9-42e2-beba-8bd780c30095", new DateTime(2021, 9, 17, 14, 56, 37, 125, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "718c7e89-5bc0-4969-84c6-d87188069603", new DateTime(2021, 9, 17, 14, 56, 37, 125, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "1cf88982-940d-46fe-83e7-8d711dd75e33", new DateTime(2021, 9, 17, 14, 56, 37, 125, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "34ffdad4-5bc3-4b51-90c7-4d6934318f15", new DateTime(2021, 9, 17, 14, 56, 37, 125, DateTimeKind.Local).AddTicks(1055), new DateTime(2021, 9, 17, 14, 56, 37, 119, DateTimeKind.Local).AddTicks(7496), "AQAAAAEAACcQAAAAEFsxDIvgZsQShnnmQ3geTVuuNgdiomPJNOLxWopYSG0iA9xWdTuqs94pBzaouf+TBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "4a6fd114-e710-4e27-9434-e436d99974e4", new DateTime(2021, 9, 17, 14, 56, 37, 119, DateTimeKind.Local).AddTicks(7486), new DateTime(2021, 9, 17, 14, 56, 37, 114, DateTimeKind.Local).AddTicks(3428), "AQAAAAEAACcQAAAAEPOyoasi85PEifB3hbSPtvh111RbeOZrvPql7Eq3cEapiRIaFUIvnhEwiaoOD/RRuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "5d4c9c28-8508-49da-bf84-a6e80ebed5fa", new DateTime(2021, 9, 17, 14, 56, 37, 114, DateTimeKind.Local).AddTicks(3000), new DateTime(2021, 9, 17, 14, 56, 37, 107, DateTimeKind.Local).AddTicks(2336), "AQAAAAEAACcQAAAAEH26wMWxSX9Kwwk/l9TeHJ3Zf8OKnHftQF0x6YEJTf+1iQwbAS2s0xR++Y2fc+uzTQ==" });
        }
    }
}
