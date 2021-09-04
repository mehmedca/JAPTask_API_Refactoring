using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JAP.Database.Migrations
{
    public partial class AddManyToManyRelBetwActorsAndMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Actors_Movies_MovieId",
            //    table: "Actors");

            //migrationBuilder.DropIndex(
            //    name: "IX_Actors_MovieId",
            //    table: "Actors");

            //migrationBuilder.DropColumn(
            //    name: "MovieId",
            //    table: "Actors");

            migrationBuilder.AddColumn<double>(
                name: "RatingTotal",
                table: "Movies",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "ActorsInMovies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ActorId = table.Column<int>(type: "integer", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorsInMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActorsInMovies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActorsInMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 340, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 340, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 340, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 340, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 340, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 340, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "c7ae3798-c41c-4838-8d46-e990dea8e888", new DateTime(2021, 9, 5, 1, 36, 21, 339, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "fdb52333-8430-43a0-bf5b-9508b0e0a8d9", new DateTime(2021, 9, 5, 1, 36, 21, 339, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "a7540a5a-39d7-4df3-b8da-5c3c10d8f073", new DateTime(2021, 9, 5, 1, 36, 21, 339, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "1b6a93ed-225b-49c5-9cec-1d5577d7acfc", new DateTime(2021, 9, 5, 1, 36, 21, 339, DateTimeKind.Local).AddTicks(1217), new DateTime(2021, 9, 5, 1, 36, 21, 333, DateTimeKind.Local).AddTicks(7496), "AQAAAAEAACcQAAAAEJv2xK3FVSwJuYTq5IeiybodIjs3zb/UL2ysrL5sH7APB9o7ErliZJEpDT7RCthZww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "2fa2de0b-07fc-41a9-89ac-dd627f21ddbb", new DateTime(2021, 9, 5, 1, 36, 21, 333, DateTimeKind.Local).AddTicks(7487), new DateTime(2021, 9, 5, 1, 36, 21, 328, DateTimeKind.Local).AddTicks(3261), "AQAAAAEAACcQAAAAEC3zVhb26CeMYbYwtHJn+lUimF8sy8YsJHk/QGilAOkgVrfG2xMqgyLeOxRaSVWgaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "91a40f83-0c37-4adf-adcc-19bce6c8f1a1", new DateTime(2021, 9, 5, 1, 36, 21, 328, DateTimeKind.Local).AddTicks(2751), new DateTime(2021, 9, 5, 1, 36, 21, 321, DateTimeKind.Local).AddTicks(1543), "AQAAAAEAACcQAAAAEA65Q/XXktHerHSsTMCTSlQe5zmo0lAYuCdcAvbI+Wqmt5nSv2cRwcaCxPgfmQf70g==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 341, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 341, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 341, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 341, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 341, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.CreateIndex(
                name: "IX_ActorsInMovies_ActorId",
                table: "ActorsInMovies",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorsInMovies_MovieId",
                table: "ActorsInMovies",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorsInMovies");

            migrationBuilder.DropColumn(
                name: "RatingTotal",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Actors",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 13, 31, 984, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 13, 31, 984, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 13, 31, 984, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 13, 31, 984, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 13, 31, 984, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 13, 31, 984, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "5635f137-4f84-49df-aa89-caf70fb9801b", new DateTime(2021, 9, 3, 18, 13, 31, 982, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "349ec230-3d93-4ca9-9dd8-f9fbd5836dcc", new DateTime(2021, 9, 3, 18, 13, 31, 982, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "f83fc824-b5c1-47af-a932-66821fbe6cb2", new DateTime(2021, 9, 3, 18, 13, 31, 982, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "5c56b6d4-da84-44da-a124-c77f9aaa3c4b", new DateTime(2021, 9, 3, 18, 13, 31, 981, DateTimeKind.Local).AddTicks(6528), new DateTime(2021, 9, 3, 18, 13, 31, 973, DateTimeKind.Local).AddTicks(2236), "AQAAAAEAACcQAAAAEPocPiSBp1R/j5eEkU+RnG5qv8hnM73k5zWuNCL6AM5V8KUH8M6p4NUdUysgXyGjzw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "dcbd7037-26f7-43d4-88a3-17bfee3e0c9f", new DateTime(2021, 9, 3, 18, 13, 31, 973, DateTimeKind.Local).AddTicks(2216), new DateTime(2021, 9, 3, 18, 13, 31, 964, DateTimeKind.Local).AddTicks(7045), "AQAAAAEAACcQAAAAEJuH+FvFcnPMGzJpSY2mQgC+LablOyAZsu8Y8pLgcDl0ZhwxpaQllIEidCPL0W41Mg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "88046105-2b02-422a-a398-f5a508289021", new DateTime(2021, 9, 3, 18, 13, 31, 964, DateTimeKind.Local).AddTicks(6211), new DateTime(2021, 9, 3, 18, 13, 31, 954, DateTimeKind.Local).AddTicks(1847), "AQAAAAEAACcQAAAAEHz2au++1Ri5yytHX+hQ7OjIfdRTkCoWsYRrg7G4ha2yl3mV7G18xOW21jnfKPzE7w==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 13, 31, 985, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 13, 31, 985, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 13, 31, 985, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 13, 31, 985, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 13, 31, 985, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.CreateIndex(
                name: "IX_Actors_MovieId",
                table: "Actors",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_MovieId",
                table: "Actors",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
