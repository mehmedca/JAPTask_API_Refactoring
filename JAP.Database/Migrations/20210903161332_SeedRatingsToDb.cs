using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class SeedRatingsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RatingInt",
                table: "Ratings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MovieId", "RatedById", "RatedByUserId", "RatingInt" },
                values: new object[,]
                {
                    { -9, -5, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { -8, -4, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { -7, -4, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { -6, -3, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { -5, -3, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { -4, -2, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { -3, -2, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { -2, -1, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { -10, -5, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { -1, -1, "NsOUTyrRU3CRxdPY06lP", null, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "RatingInt",
                table: "Ratings");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 6, 4, 887, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 6, 4, 887, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 6, 4, 887, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 6, 4, 887, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 6, 4, 887, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 6, 4, 887, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "a76c570f-0af0-44df-8559-36066de6e7de", new DateTime(2021, 9, 3, 18, 6, 4, 886, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "c7f27b05-c866-46a5-a8eb-f9dd8bf63e7c", new DateTime(2021, 9, 3, 18, 6, 4, 886, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "2c7f83a4-8656-4bef-9d3a-e38845591866", new DateTime(2021, 9, 3, 18, 6, 4, 886, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "73e87ecf-163f-4427-833b-dadfa4cf61e6", new DateTime(2021, 9, 3, 18, 6, 4, 885, DateTimeKind.Local).AddTicks(3918), new DateTime(2021, 9, 3, 18, 6, 4, 877, DateTimeKind.Local).AddTicks(9471), "AQAAAAEAACcQAAAAEGHrApciJQ+7wMRrsBUGKoiFq27E7LOdTzQaHXuvYo6g5FS1i6WFYNOx3yfLV4rfMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "a3b28f9e-db7c-476c-ae82-9ea6f4fde893", new DateTime(2021, 9, 3, 18, 6, 4, 877, DateTimeKind.Local).AddTicks(9447), new DateTime(2021, 9, 3, 18, 6, 4, 870, DateTimeKind.Local).AddTicks(4418), "AQAAAAEAACcQAAAAEHQzSmRiQudDM8I4iyRaN+qh3J5Y9hrY9dcLw2QdRr1fGrjuTVNa9+Ad4iqv/TfKHw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "7b3cf50d-2779-40a3-a1cb-8060dd91ca2b", new DateTime(2021, 9, 3, 18, 6, 4, 870, DateTimeKind.Local).AddTicks(3837), new DateTime(2021, 9, 3, 18, 6, 4, 860, DateTimeKind.Local).AddTicks(5233), "AQAAAAEAACcQAAAAENDpsQ1gbg101YRCIgwhtwVY0JAOJixS/o1hwUDRRUCNmih/lvRgPVUFQp0an38f4Q==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 6, 4, 888, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 6, 4, 888, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 6, 4, 888, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 6, 4, 888, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 18, 6, 4, 888, DateTimeKind.Local).AddTicks(3989));
        }
    }
}
