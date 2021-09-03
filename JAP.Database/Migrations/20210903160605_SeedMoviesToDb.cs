using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class SeedMoviesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedById", "CreatedByUserId", "DateCreated", "DateDeleted", "DateModified", "DeletedById", "DeletedByUserId", "Description", "IsDeleted", "ModifiedById", "ModifiedByUserId", "PhotoId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { -5, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 3, 18, 6, 4, 888, DateTimeKind.Local).AddTicks(5213), null, null, null, null, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", false, null, null, -11, new DateTime(2008, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { -4, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 3, 18, 6, 4, 888, DateTimeKind.Local).AddTicks(5207), null, null, null, null, "Two spies are recruited by an intelligence agency. They pose as a married couple Mr. and Mrs. Smith when they are on their missions.", false, null, null, -10, new DateTime(2005, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mr and Mrs Smith" },
                    { -3, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 3, 18, 6, 4, 888, DateTimeKind.Local).AddTicks(5200), null, null, null, null, "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X", false, null, null, -9, new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suicide Squad" },
                    { -2, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 3, 18, 6, 4, 888, DateTimeKind.Local).AddTicks(5192), null, null, null, null, "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", false, null, null, -8, new DateTime(1972, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" },
                    { -1, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 3, 18, 6, 4, 888, DateTimeKind.Local).AddTicks(3989), null, null, null, null, "A happily married man's life is turned upside down when his wife is killed in a mysterious hit-and-run accident in Tel Aviv.", false, null, null, -7, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hit and Run" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "f92bc324-e94c-4455-ba3f-3cdde6417b4f", new DateTime(2021, 9, 3, 17, 55, 46, 553, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "1b346682-3371-408d-ab71-264bc31a9fac", new DateTime(2021, 9, 3, 17, 55, 46, 553, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "72c0f2f7-f720-4669-bcce-73dd9ef792dd", new DateTime(2021, 9, 3, 17, 55, 46, 553, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "fa9c5387-28af-42a4-92ac-d30b2f84f310", new DateTime(2021, 9, 3, 17, 55, 46, 552, DateTimeKind.Local).AddTicks(8172), new DateTime(2021, 9, 3, 17, 55, 46, 545, DateTimeKind.Local).AddTicks(3010), "AQAAAAEAACcQAAAAEN989qrXHFRuWOFnQMaMHxBnI79HqoIBq8IsbbqCnFLIToi0VWUkE8A0RlLEPCE6Fw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "743526d2-0265-4084-85ba-58487c6275dd", new DateTime(2021, 9, 3, 17, 55, 46, 545, DateTimeKind.Local).AddTicks(2996), new DateTime(2021, 9, 3, 17, 55, 46, 537, DateTimeKind.Local).AddTicks(6603), "AQAAAAEAACcQAAAAEMFgAlTchAoNjKU2iL/DATJBeWTJlS6yIJmCigSfhsBjW1OQETWVsy/h9I60F3Snuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "56f2f1a3-e625-4c69-b108-29009eb84195", new DateTime(2021, 9, 3, 17, 55, 46, 537, DateTimeKind.Local).AddTicks(5925), new DateTime(2021, 9, 3, 17, 55, 46, 527, DateTimeKind.Local).AddTicks(5427), "AQAAAAEAACcQAAAAEIsq/bpvjKt3Q65Bq6GHWiV1m8AZTIpC3VAoazG7EGA6cN/QpvHe2iJS1OiwP8TP9g==" });
        }
    }
}
