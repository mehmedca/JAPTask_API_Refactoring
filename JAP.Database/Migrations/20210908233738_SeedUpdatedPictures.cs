using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class SeedUpdatedPictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "10c07a73-dd7a-4b00-a7f6-ce902e096012", new DateTime(2021, 9, 9, 1, 37, 37, 752, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "66d1cb3b-cf68-43ab-b4cd-0f1d25baf329", new DateTime(2021, 9, 9, 1, 37, 37, 752, DateTimeKind.Local).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "dc65f26b-2de8-4c73-b4ca-46c8e4788cda", new DateTime(2021, 9, 9, 1, 37, 37, 752, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "cb739352-91df-4bcb-9dd6-9e000e0e2d4e", new DateTime(2021, 9, 9, 1, 37, 37, 750, DateTimeKind.Local).AddTicks(5197), new DateTime(2021, 9, 9, 1, 37, 37, 740, DateTimeKind.Local).AddTicks(1740), "AQAAAAEAACcQAAAAEINM29npV9dDldhS3We6OGp0j7AV7ykxIK6ITWPBmyxDcr0/9z3aTWbRn4AuRx6ArA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "831a9f80-007a-4730-8a5b-2c9a351a2eaa", new DateTime(2021, 9, 9, 1, 37, 37, 740, DateTimeKind.Local).AddTicks(1670), new DateTime(2021, 9, 9, 1, 37, 37, 726, DateTimeKind.Local).AddTicks(932), "AQAAAAEAACcQAAAAEC6eS25PZe7LQGb9In/l+eGanB3BYnRLnnjTCDkpWfKaKCaRrMHgEnYUNvwjn95OLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "4e5a83bf-8e6c-4b44-abde-9747febf577f", new DateTime(2021, 9, 9, 1, 37, 37, 725, DateTimeKind.Local).AddTicks(9399), new DateTime(2021, 9, 9, 1, 37, 37, 706, DateTimeKind.Local).AddTicks(2897), "AQAAAAEAACcQAAAAEAiYWBh05qY76iCjfdkVA4+EPFvn8d+GkUWCdiOlCZk5dFgSAN0h3vFlwtIFcAn32g==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "PublicId", "Url" },
                values: new object[] { "titans22_pipzsv", "https://res.cloudinary.com/doisz5wiz/image/upload/v1631143524/titans22_pipzsv.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "PublicId", "Url" },
                values: new object[] { "greys22_jb0wr9", "https://res.cloudinary.com/doisz5wiz/image/upload/v1631143519/greys22_jb0wr9.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "PublicId", "Url" },
                values: new object[] { "peaky22_nokwxv", "https://res.cloudinary.com/doisz5wiz/image/upload/v1631143519/peaky22_nokwxv.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "PublicId", "Url" },
                values: new object[] { "beckett22_icrxsl", "https://res.cloudinary.com/doisz5wiz/image/upload/v1631143527/beckett22_icrxsl.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "PublicId", "Url" },
                values: new object[] { "spiderman22_ev68ek", "https://res.cloudinary.com/doisz5wiz/image/upload/v1631143529/spiderman22_ev68ek.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "PublicId", "Url" },
                values: new object[] { "pig22_egzevy", "https://res.cloudinary.com/doisz5wiz/image/upload/v1631143530/pig22_egzevy.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 20, 13, 41, 38, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "PublicId", "Url" },
                values: new object[] { "titans_hkz342", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872086/titans_hkz342.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "PublicId", "Url" },
                values: new object[] { "greys_fczdub", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872074/greys_fczdub.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "PublicId", "Url" },
                values: new object[] { "peakyblinders_jz6bxi", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872070/peakyblinders_jz6bxi.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "PublicId", "Url" },
                values: new object[] { "beckett-2021_nco3v7", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871035/beckett-2021_nco3v7.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "PublicId", "Url" },
                values: new object[] { "nowayhome_xivojd", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871035/nowayhome_xivojd.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "PublicId", "Url" },
                values: new object[] { "pig_byciwz", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871033/pig_byciwz.jpg" });
        }
    }
}
