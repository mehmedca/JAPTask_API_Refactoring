using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class UpdateSeedRatings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 34, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 34, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 34, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 34, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 34, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 34, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 34, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 34, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 34, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 33, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "f8974530-926d-4712-957a-e6824a893566", new DateTime(2021, 9, 6, 20, 13, 41, 31, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "b82eb5cc-8ad8-413a-878c-5294e9ae6655", new DateTime(2021, 9, 6, 20, 13, 41, 31, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "641b2004-7ceb-4878-a92e-452079231b86", new DateTime(2021, 9, 6, 20, 13, 41, 31, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "892cb672-dd04-40f5-a792-6f6e335c509b", new DateTime(2021, 9, 6, 20, 13, 41, 29, DateTimeKind.Local).AddTicks(8396), new DateTime(2021, 9, 6, 20, 13, 41, 19, DateTimeKind.Local).AddTicks(7092), "AQAAAAEAACcQAAAAEF57zws0po1yQ5tCsnpgVN4iHzibRwUZaSdr+sqriqrK0+9e17+M/9v5gvHMnVnxaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "4bd14c1b-5fac-4e38-a12f-b59b05dfdbb0", new DateTime(2021, 9, 6, 20, 13, 41, 19, DateTimeKind.Local).AddTicks(6988), new DateTime(2021, 9, 6, 20, 13, 41, 9, DateTimeKind.Local).AddTicks(5000), "AQAAAAEAACcQAAAAEMUvnn3HhwHM6B8r3koDdx5EBjWSeW+v3Bd5F9rrmpmKpgFVqe/TGMuM5BIOO+h0aw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "e0ac3a48-3669-43a5-ad90-5833fc2266b2", new DateTime(2021, 9, 6, 20, 13, 41, 9, DateTimeKind.Local).AddTicks(3762), new DateTime(2021, 9, 6, 20, 13, 40, 995, DateTimeKind.Local).AddTicks(9576), "AQAAAAEAACcQAAAAEE+Jzo+qWNP90rqoWJvvx5RcYHUFqJJavGafjh0AXlbVVyq5C0Ah1qKXhjyeJNLaEw==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8299), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8286), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8274), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8246), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8232), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8215), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8193), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8180), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8160), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8147), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8133), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(7255), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(7244), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(7200), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6627), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6613), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6593), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6575), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6555), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6517), 2.5 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6498), 4.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6473), 3.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6446), 4.5 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(2015), 3.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "dd314dc5-64c5-42bb-8839-9a943eecd299", new DateTime(2021, 9, 6, 0, 20, 13, 420, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "d74a384d-937a-4cdd-be04-65a1ea869b30", new DateTime(2021, 9, 6, 0, 20, 13, 420, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "518a1092-8991-406f-bcce-b13cca6a2ec6", new DateTime(2021, 9, 6, 0, 20, 13, 420, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "681ac9ef-dd94-42b3-be57-42263551c86f", new DateTime(2021, 9, 6, 0, 20, 13, 419, DateTimeKind.Local).AddTicks(5615), new DateTime(2021, 9, 6, 0, 20, 13, 412, DateTimeKind.Local).AddTicks(949), "AQAAAAEAACcQAAAAELFltfcsghV/kFf9TTRcTg6pGiuDjEYg6kZwdHiDBq95Ts2PyAjSsNzWUJHggH93bw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "2d43c2c0-9f87-4abb-99c2-4deabdcbe61c", new DateTime(2021, 9, 6, 0, 20, 13, 412, DateTimeKind.Local).AddTicks(935), new DateTime(2021, 9, 6, 0, 20, 13, 404, DateTimeKind.Local).AddTicks(4236), "AQAAAAEAACcQAAAAEFJSCdG/kuEzuwFt5U+aKDw/6LlyC467iMcCDcylOH4rEh0C/1n61t8HmleuD/TIMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "997e3fbb-a914-4260-b8ea-e9daa5f42599", new DateTime(2021, 9, 6, 0, 20, 13, 404, DateTimeKind.Local).AddTicks(3658), new DateTime(2021, 9, 6, 0, 20, 13, 394, DateTimeKind.Local).AddTicks(3874), "AQAAAAEAACcQAAAAENQ7xiCkYfbO5gBpRWSEj9QFUlH5CQwkbfsC2yBOrdOe8MAFxcrO//0CHTxlloEhtA==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6220), 2.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6213), 2.8799999999999999 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6207), 3.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6162), 3.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6156), 3.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6150), 3.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6144), 3.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6137), 5.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6131), 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6124), 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6117), 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5818), 4.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5812), 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5805), 2.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5798), 5.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5792), 3.5499999999999998 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5786), 3.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5780), 3.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5773), 3.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5767), 5.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5761), 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5754), 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5744), 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(4214), 4.0 });
        }
    }
}
