using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class SeedRatings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "efa94352-7eee-4dc4-a465-3dd06b9ee34b", new DateTime(2021, 9, 17, 14, 51, 21, 411, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "52645599-526f-4115-be78-3835679e48e1", new DateTime(2021, 9, 17, 14, 51, 21, 411, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "da4a5062-867e-4b43-afef-c55113a2cbd2", new DateTime(2021, 9, 17, 14, 51, 21, 411, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "58a8f465-6a43-4f03-9ff7-eafc86f8c94a", new DateTime(2021, 9, 17, 14, 51, 21, 410, DateTimeKind.Local).AddTicks(2960), new DateTime(2021, 9, 17, 14, 51, 21, 404, DateTimeKind.Local).AddTicks(9408), "AQAAAAEAACcQAAAAEK4F4T1jre/NdtJ5CcwD/FzdGM12pXwS1S0jKeZh1hO99wWlKyHcRZlQ0fyjecjjzw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "c8e011e3-aadb-417f-9b81-0479bc295376", new DateTime(2021, 9, 17, 14, 51, 21, 404, DateTimeKind.Local).AddTicks(9400), new DateTime(2021, 9, 17, 14, 51, 21, 399, DateTimeKind.Local).AddTicks(5480), "AQAAAAEAACcQAAAAEArKd/AAukCHbxJSulD4jAVXE7r86t9n1XTmnDuXsh+9MNfezW/ihDu0c+uhAbYLEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "9cf8850b-120d-4d29-883b-825d427f7695", new DateTime(2021, 9, 17, 14, 51, 21, 399, DateTimeKind.Local).AddTicks(5067), new DateTime(2021, 9, 17, 14, 51, 21, 392, DateTimeKind.Local).AddTicks(4226), "AQAAAAEAACcQAAAAEJINQNBvW+fdUOn+qUqQ+wNTRSSrAFsG5CRdiwLE9U/dNhB7iWcHEMmqe+ziU0A9EA==" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MovieId", "RatedById", "RatedByUserId", "RatingInt" },
                values: new object[,]
                {
                    { 90, 45, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 89, 45, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 88, 44, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 87, 44, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 86, 43, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 85, 43, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 84, 42, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 83, 42, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 82, 41, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 81, 41, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 80, 40, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 79, 40, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 91, 46, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 78, 39, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 76, 38, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 75, 38, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 74, 37, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 73, 37, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 72, 36, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 71, 36, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 70, 35, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 69, 35, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 68, 34, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 67, 34, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 66, 33, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 65, 33, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 77, 39, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 120, 60, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 92, 46, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 64, 32, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 119, 60, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 118, 59, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 117, 59, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 116, 58, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 115, 58, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 114, 57, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 113, 57, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 112, 56, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 111, 56, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 110, 55, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 109, 55, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 108, 54, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 107, 54, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 106, 53, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 105, 53, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 104, 52, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 103, 52, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 102, 51, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 101, 51, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 100, 50, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 99, 50, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 98, 49, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 97, 49, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 96, 48, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 95, 48, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 93, 47, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 94, 47, "NsOUTyrRU3CRxdPY06lP", null, 5 },
                    { 63, 32, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 61, 31, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 28, 14, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 27, 14, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 26, 13, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 25, 13, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 24, 12, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 23, 12, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 22, 11, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 21, 11, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 20, 10, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 19, 10, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 18, 9, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 17, 9, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 16, 8, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 15, 8, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 14, 7, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 13, 7, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 12, 6, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 11, 6, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 10, 5, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 9, 5, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 8, 4, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 7, 4, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 6, 3, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 5, 3, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 4, 2, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 3, 2, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 2, 1, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 29, 15, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 30, 15, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 31, 16, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 32, 16, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 60, 30, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 59, 30, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 58, 29, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 57, 29, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 56, 28, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 55, 28, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 54, 27, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 53, 27, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 52, 26, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 51, 26, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 50, 25, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 49, 25, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 48, 24, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 62, 31, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 47, 24, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 45, 23, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 44, 22, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 43, 22, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 42, 21, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 41, 21, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 40, 20, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 39, 20, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 38, 19, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 37, 19, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 36, 18, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 35, 18, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 34, 17, "NsOUTyrRU3CRxdPY06lP", null, 3 },
                    { 33, 17, "NsOUTyrRU3CRxdPY06lP", null, 2 },
                    { 46, 23, "NsOUTyrRU3CRxdPY06lP", null, 4 },
                    { 1, 1, "NsOUTyrRU3CRxdPY06lP", null, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "fffcca6c-49e9-4dc9-bf64-acd502b8b2e4", new DateTime(2021, 9, 17, 0, 50, 16, 315, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "9b038258-06c2-4a72-9e93-a6cdbfe99bb8", new DateTime(2021, 9, 17, 0, 50, 16, 315, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "4094c219-d867-4a4f-ae74-2bfbe4bb02af", new DateTime(2021, 9, 17, 0, 50, 16, 315, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "ffa86d35-53c8-4199-93c7-cb263bc4fa29", new DateTime(2021, 9, 17, 0, 50, 16, 314, DateTimeKind.Local).AddTicks(7647), new DateTime(2021, 9, 17, 0, 50, 16, 307, DateTimeKind.Local).AddTicks(3802), "AQAAAAEAACcQAAAAEIzCm8a+yig/1SQO2VDj8aS3NpQNGCuewnqiHG2egtfAlv4TurfH1wmA8y5Broca7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "69768b9a-4b45-4120-8960-25f07cfa5bad", new DateTime(2021, 9, 17, 0, 50, 16, 307, DateTimeKind.Local).AddTicks(3789), new DateTime(2021, 9, 17, 0, 50, 16, 299, DateTimeKind.Local).AddTicks(9516), "AQAAAAEAACcQAAAAEMbv7dEb2QOGq5/LaRbGueGvtMLlnTunQm4YV+B2GpUP6x3BelnE2yd/Y35+624K2w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "89650986-5c1d-4eb7-9243-70b33f3558e8", new DateTime(2021, 9, 17, 0, 50, 16, 299, DateTimeKind.Local).AddTicks(8947), new DateTime(2021, 9, 17, 0, 50, 16, 290, DateTimeKind.Local).AddTicks(2022), "AQAAAAEAACcQAAAAEOfTaAuwOJHNYW7CJtmCqfZcizGQUIRPoSR7kSRJ6v45Fk/e9xVa4eOtCk/womYl8Q==" });
        }
    }
}
