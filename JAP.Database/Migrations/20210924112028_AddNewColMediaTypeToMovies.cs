using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class AddNewColMediaTypeToMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTvShow",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "MediaType",
                table: "Movies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "86cc9af7-1c84-40aa-b471-bcd9fdfc7882", new DateTime(2021, 9, 24, 13, 20, 27, 47, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "33c8d474-f355-4967-87ff-64ed84411175", new DateTime(2021, 9, 24, 13, 20, 27, 47, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "037a83b2-fa54-4341-a2dd-74d03f0101b6", new DateTime(2021, 9, 24, 13, 20, 27, 47, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "790e6fef-7446-4730-a446-f8e5adbb76c0", new DateTime(2021, 9, 24, 13, 20, 27, 46, DateTimeKind.Local).AddTicks(7602), new DateTime(2021, 9, 24, 13, 20, 27, 39, DateTimeKind.Local).AddTicks(3864), "AQAAAAEAACcQAAAAED93WS/ldg0na83DqUN5Q2af2rqBFKU//XnBf0gr3m2PcN6pYyqEt7nOetM6RHNKwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "5f551322-e159-4315-a739-e6fda9af3da1", new DateTime(2021, 9, 24, 13, 20, 27, 39, DateTimeKind.Local).AddTicks(3851), new DateTime(2021, 9, 24, 13, 20, 27, 31, DateTimeKind.Local).AddTicks(9781), "AQAAAAEAACcQAAAAEL/Ow4tYrvIbtE44vy3XfR/N+nfvfVONipkRICmBFbZN3kBaNO5S3ERs2WwZoqzgFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "9e283c53-9259-4ca6-9eac-6253b2c06e12", new DateTime(2021, 9, 24, 13, 20, 27, 31, DateTimeKind.Local).AddTicks(9212), new DateTime(2021, 9, 24, 13, 20, 27, 22, DateTimeKind.Local).AddTicks(2505), "AQAAAAEAACcQAAAAEKG0FlfBNvjgX5/C2PWSRJ4kEWpEK/T422R2tfttzgEHg/ZbZ2ZG+zNEpkMhtVT/lg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MediaType",
                table: "Movies");

            migrationBuilder.AddColumn<bool>(
                name: "IsTvShow",
                table: "Movies",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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
    }
}
