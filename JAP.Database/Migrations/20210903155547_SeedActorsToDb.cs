using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class SeedActorsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "Movies",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "Actors",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "CreatedById", "CreatedByUserId", "DateCreated", "DateDeleted", "DateModified", "DeletedById", "DeletedByUserId", "FirstName", "IsDeleted", "LastName", "ModifiedById", "ModifiedByUserId", "MovieId", "PhotoId" },
                values: new object[,]
                {
                    { -1, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(767), null, null, null, null, "Johnny", false, "Depp", null, null, null, -1 },
                    { -2, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1901), null, null, null, null, "Angelina", false, "Jolie", null, null, null, -2 },
                    { -3, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1908), null, null, null, null, "Tom", false, "Hanks", null, null, null, -3 },
                    { -4, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1914), null, null, null, null, "Natalie", false, "Portman", null, null, null, -4 },
                    { -5, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1920), null, null, null, null, "Scarlett", false, "Johansson", null, null, null, -5 },
                    { -6, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 3, 17, 55, 46, 555, DateTimeKind.Local).AddTicks(1925), null, null, null, null, "Brad", false, "Pitt", null, null, null, -6 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "Movies",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "Actors",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "0a329d69-8e6e-4082-80a1-1c052447e36c", new DateTime(2021, 9, 3, 17, 48, 33, 225, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "b78440a5-da05-48d2-a8f9-70e29f7ea6fe", new DateTime(2021, 9, 3, 17, 48, 33, 225, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "8c9298d0-b2fa-459b-869c-e5a818022e52", new DateTime(2021, 9, 3, 17, 48, 33, 225, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "6456c7d4-207a-41a7-a00b-97bcb4248233", new DateTime(2021, 9, 3, 17, 48, 33, 224, DateTimeKind.Local).AddTicks(6692), new DateTime(2021, 9, 3, 17, 48, 33, 217, DateTimeKind.Local).AddTicks(1648), "AQAAAAEAACcQAAAAEK9gHGo11bG4pKZEY1koUF7cEf1F+CLh50CBwnmFKpI01IvOSAq9uT+XD6BhR7OGlw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "2405bd71-f52d-4706-b798-d09705cd5fdf", new DateTime(2021, 9, 3, 17, 48, 33, 217, DateTimeKind.Local).AddTicks(1631), new DateTime(2021, 9, 3, 17, 48, 33, 209, DateTimeKind.Local).AddTicks(4746), "AQAAAAEAACcQAAAAEDg6gmbnDxTSw5p1YD+BdDCO1ILncXKurz5v1fBR2bKhsm2ICzc7CMopz/r/07hpug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "f43e18fc-be19-46c3-8685-cef8574f746d", new DateTime(2021, 9, 3, 17, 48, 33, 209, DateTimeKind.Local).AddTicks(4162), new DateTime(2021, 9, 3, 17, 48, 33, 199, DateTimeKind.Local).AddTicks(4214), "AQAAAAEAACcQAAAAEB2L8gu1Fond/1x2n1fZDtCtoxh/YzcWrifqx/txNzaaGs6H2DVN4diPn6txaNUkqA==" });
        }
    }
}
