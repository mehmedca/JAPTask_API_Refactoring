using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class SeedScreenings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "1c632e29-bd88-4b02-b13a-27b4de663d02", new DateTime(2021, 9, 17, 0, 16, 18, 919, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "b3b09fc0-beb0-4b80-8fa4-4856e0c4ab26", new DateTime(2021, 9, 17, 0, 16, 18, 919, DateTimeKind.Local).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "ffda9992-e254-45ba-9738-f1cbeb195dfb", new DateTime(2021, 9, 17, 0, 16, 18, 919, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "86569475-e29b-4a00-8939-6301650a194f", new DateTime(2021, 9, 17, 0, 16, 18, 918, DateTimeKind.Local).AddTicks(4658), new DateTime(2021, 9, 17, 0, 16, 18, 911, DateTimeKind.Local).AddTicks(1005), "AQAAAAEAACcQAAAAEKQN8jOQ1HVTMBegJxNdkkAoXQOIx6LOh03SHU52GTT9aVCe6A3yvCUZDeG0PdjMxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "3fffa834-7ba6-4334-8b05-17de680bb9fd", new DateTime(2021, 9, 17, 0, 16, 18, 911, DateTimeKind.Local).AddTicks(993), new DateTime(2021, 9, 17, 0, 16, 18, 903, DateTimeKind.Local).AddTicks(6831), "AQAAAAEAACcQAAAAEEdT6wYf7Uh1n7G/GZBuHND019PnR0GnnQ2FFhva8Btvc5VJN+LX7nUQh17hICZsAA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "217fbf54-2d88-4e1f-ba80-6b347d43a7d4", new DateTime(2021, 9, 17, 0, 16, 18, 903, DateTimeKind.Local).AddTicks(6243), new DateTime(2021, 9, 17, 0, 16, 18, 893, DateTimeKind.Local).AddTicks(8984), "AQAAAAEAACcQAAAAECv30vwc4bd6PXGxPZeHDZxSPuHFGFAuLozB76RsfoJ2sWI9DDTKS2qmfFbhkoy+SQ==" });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "EndDate", "MovieId", "StartDate" },
                values: new object[,]
                {
                    { 97, new DateTime(2021, 10, 27, 8, 4, 19, 0, DateTimeKind.Unspecified), 97, new DateTime(2021, 10, 7, 12, 14, 3, 0, DateTimeKind.Unspecified) },
                    { 98, new DateTime(2021, 10, 28, 2, 19, 53, 0, DateTimeKind.Unspecified), 98, new DateTime(2021, 10, 19, 1, 5, 16, 0, DateTimeKind.Unspecified) },
                    { 99, new DateTime(2021, 10, 21, 11, 40, 30, 0, DateTimeKind.Unspecified), 99, new DateTime(2021, 10, 13, 12, 15, 14, 0, DateTimeKind.Unspecified) },
                    { 101, new DateTime(2021, 10, 26, 6, 57, 17, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 18, 11, 47, 53, 0, DateTimeKind.Unspecified) },
                    { 102, new DateTime(2021, 10, 23, 1, 5, 11, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 10, 25, 4, 54, 44, 0, DateTimeKind.Unspecified) },
                    { 103, new DateTime(2021, 10, 6, 3, 31, 55, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 10, 11, 1, 20, 7, 0, DateTimeKind.Unspecified) },
                    { 96, new DateTime(2021, 10, 7, 12, 4, 58, 0, DateTimeKind.Unspecified), 96, new DateTime(2021, 10, 19, 6, 4, 7, 0, DateTimeKind.Unspecified) },
                    { 104, new DateTime(2021, 10, 16, 2, 51, 12, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 10, 14, 12, 22, 43, 0, DateTimeKind.Unspecified) },
                    { 106, new DateTime(2021, 10, 2, 12, 54, 59, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 10, 10, 12, 38, 5, 0, DateTimeKind.Unspecified) },
                    { 107, new DateTime(2021, 10, 15, 8, 53, 7, 0, DateTimeKind.Unspecified), 7, new DateTime(2021, 10, 15, 1, 54, 38, 0, DateTimeKind.Unspecified) },
                    { 108, new DateTime(2021, 10, 25, 11, 7, 6, 0, DateTimeKind.Unspecified), 8, new DateTime(2021, 10, 14, 7, 11, 6, 0, DateTimeKind.Unspecified) },
                    { 109, new DateTime(2021, 10, 11, 12, 21, 5, 0, DateTimeKind.Unspecified), 9, new DateTime(2021, 10, 25, 6, 34, 57, 0, DateTimeKind.Unspecified) },
                    { 110, new DateTime(2021, 10, 21, 10, 4, 31, 0, DateTimeKind.Unspecified), 10, new DateTime(2021, 10, 6, 8, 57, 46, 0, DateTimeKind.Unspecified) },
                    { 111, new DateTime(2021, 10, 4, 3, 50, 38, 0, DateTimeKind.Unspecified), 11, new DateTime(2021, 10, 5, 1, 52, 32, 0, DateTimeKind.Unspecified) },
                    { 105, new DateTime(2021, 10, 8, 9, 36, 16, 0, DateTimeKind.Unspecified), 5, new DateTime(2021, 10, 4, 10, 30, 43, 0, DateTimeKind.Unspecified) },
                    { 112, new DateTime(2021, 10, 13, 2, 39, 2, 0, DateTimeKind.Unspecified), 12, new DateTime(2021, 10, 12, 3, 16, 41, 0, DateTimeKind.Unspecified) },
                    { 95, new DateTime(2021, 10, 4, 7, 45, 41, 0, DateTimeKind.Unspecified), 95, new DateTime(2021, 10, 21, 7, 51, 9, 0, DateTimeKind.Unspecified) },
                    { 93, new DateTime(2021, 10, 4, 5, 30, 26, 0, DateTimeKind.Unspecified), 93, new DateTime(2021, 10, 15, 8, 5, 25, 0, DateTimeKind.Unspecified) },
                    { 79, new DateTime(2021, 10, 15, 4, 40, 49, 0, DateTimeKind.Unspecified), 79, new DateTime(2021, 10, 15, 1, 29, 52, 0, DateTimeKind.Unspecified) },
                    { 80, new DateTime(2021, 10, 21, 3, 6, 8, 0, DateTimeKind.Unspecified), 80, new DateTime(2021, 10, 4, 10, 43, 14, 0, DateTimeKind.Unspecified) },
                    { 81, new DateTime(2021, 10, 19, 8, 26, 21, 0, DateTimeKind.Unspecified), 81, new DateTime(2021, 10, 21, 1, 45, 57, 0, DateTimeKind.Unspecified) },
                    { 82, new DateTime(2021, 10, 7, 11, 44, 13, 0, DateTimeKind.Unspecified), 82, new DateTime(2021, 10, 6, 8, 23, 27, 0, DateTimeKind.Unspecified) },
                    { 83, new DateTime(2021, 10, 19, 11, 12, 13, 0, DateTimeKind.Unspecified), 83, new DateTime(2021, 10, 25, 6, 39, 58, 0, DateTimeKind.Unspecified) },
                    { 84, new DateTime(2021, 10, 26, 3, 52, 3, 0, DateTimeKind.Unspecified), 84, new DateTime(2021, 10, 1, 2, 28, 38, 0, DateTimeKind.Unspecified) },
                    { 94, new DateTime(2021, 10, 22, 4, 48, 18, 0, DateTimeKind.Unspecified), 94, new DateTime(2021, 10, 29, 3, 52, 15, 0, DateTimeKind.Unspecified) },
                    { 85, new DateTime(2021, 10, 3, 4, 38, 10, 0, DateTimeKind.Unspecified), 85, new DateTime(2021, 10, 8, 2, 50, 55, 0, DateTimeKind.Unspecified) },
                    { 87, new DateTime(2021, 10, 10, 10, 47, 9, 0, DateTimeKind.Unspecified), 87, new DateTime(2021, 10, 25, 6, 45, 38, 0, DateTimeKind.Unspecified) },
                    { 88, new DateTime(2021, 10, 4, 11, 44, 31, 0, DateTimeKind.Unspecified), 88, new DateTime(2021, 10, 2, 6, 33, 18, 0, DateTimeKind.Unspecified) },
                    { 89, new DateTime(2021, 10, 25, 12, 50, 5, 0, DateTimeKind.Unspecified), 89, new DateTime(2021, 10, 25, 6, 13, 25, 0, DateTimeKind.Unspecified) },
                    { 90, new DateTime(2021, 10, 25, 5, 41, 24, 0, DateTimeKind.Unspecified), 90, new DateTime(2021, 10, 12, 2, 39, 47, 0, DateTimeKind.Unspecified) },
                    { 91, new DateTime(2021, 10, 29, 9, 45, 42, 0, DateTimeKind.Unspecified), 91, new DateTime(2021, 10, 5, 9, 34, 57, 0, DateTimeKind.Unspecified) },
                    { 92, new DateTime(2021, 10, 2, 8, 37, 18, 0, DateTimeKind.Unspecified), 92, new DateTime(2021, 10, 29, 10, 24, 54, 0, DateTimeKind.Unspecified) },
                    { 86, new DateTime(2021, 10, 25, 11, 33, 57, 0, DateTimeKind.Unspecified), 86, new DateTime(2021, 10, 1, 12, 14, 18, 0, DateTimeKind.Unspecified) },
                    { 149, new DateTime(2021, 11, 11, 11, 56, 20, 0, DateTimeKind.Unspecified), 24, new DateTime(2021, 11, 23, 11, 50, 22, 0, DateTimeKind.Unspecified) },
                    { 113, new DateTime(2021, 10, 12, 2, 45, 18, 0, DateTimeKind.Unspecified), 13, new DateTime(2021, 10, 10, 11, 57, 9, 0, DateTimeKind.Unspecified) },
                    { 115, new DateTime(2021, 10, 22, 10, 32, 29, 0, DateTimeKind.Unspecified), 15, new DateTime(2021, 10, 5, 6, 26, 19, 0, DateTimeKind.Unspecified) },
                    { 135, new DateTime(2021, 11, 8, 3, 38, 43, 0, DateTimeKind.Unspecified), 10, new DateTime(2021, 11, 1, 4, 2, 54, 0, DateTimeKind.Unspecified) },
                    { 136, new DateTime(2021, 11, 20, 10, 27, 49, 0, DateTimeKind.Unspecified), 11, new DateTime(2021, 11, 12, 4, 11, 24, 0, DateTimeKind.Unspecified) },
                    { 137, new DateTime(2021, 11, 2, 12, 1, 51, 0, DateTimeKind.Unspecified), 12, new DateTime(2021, 11, 11, 9, 44, 0, 0, DateTimeKind.Unspecified) },
                    { 138, new DateTime(2021, 11, 20, 6, 36, 15, 0, DateTimeKind.Unspecified), 13, new DateTime(2021, 11, 11, 9, 25, 34, 0, DateTimeKind.Unspecified) },
                    { 139, new DateTime(2021, 11, 1, 1, 35, 18, 0, DateTimeKind.Unspecified), 14, new DateTime(2021, 11, 6, 3, 28, 12, 0, DateTimeKind.Unspecified) },
                    { 140, new DateTime(2021, 11, 16, 12, 32, 24, 0, DateTimeKind.Unspecified), 15, new DateTime(2021, 11, 1, 12, 7, 41, 0, DateTimeKind.Unspecified) },
                    { 134, new DateTime(2021, 11, 18, 1, 35, 0, 0, DateTimeKind.Unspecified), 9, new DateTime(2021, 11, 7, 11, 18, 19, 0, DateTimeKind.Unspecified) },
                    { 141, new DateTime(2021, 11, 22, 5, 19, 59, 0, DateTimeKind.Unspecified), 16, new DateTime(2021, 11, 7, 11, 53, 12, 0, DateTimeKind.Unspecified) },
                    { 143, new DateTime(2021, 11, 27, 3, 46, 43, 0, DateTimeKind.Unspecified), 18, new DateTime(2021, 11, 24, 2, 3, 36, 0, DateTimeKind.Unspecified) },
                    { 144, new DateTime(2021, 11, 27, 6, 4, 17, 0, DateTimeKind.Unspecified), 19, new DateTime(2021, 11, 23, 2, 49, 55, 0, DateTimeKind.Unspecified) },
                    { 145, new DateTime(2021, 11, 4, 4, 15, 47, 0, DateTimeKind.Unspecified), 20, new DateTime(2021, 11, 17, 8, 41, 8, 0, DateTimeKind.Unspecified) },
                    { 146, new DateTime(2021, 11, 2, 5, 2, 41, 0, DateTimeKind.Unspecified), 21, new DateTime(2021, 11, 10, 10, 43, 10, 0, DateTimeKind.Unspecified) },
                    { 147, new DateTime(2021, 11, 18, 7, 11, 6, 0, DateTimeKind.Unspecified), 22, new DateTime(2021, 11, 26, 11, 17, 6, 0, DateTimeKind.Unspecified) },
                    { 148, new DateTime(2021, 11, 7, 9, 49, 59, 0, DateTimeKind.Unspecified), 23, new DateTime(2021, 11, 23, 11, 24, 14, 0, DateTimeKind.Unspecified) },
                    { 142, new DateTime(2021, 11, 14, 9, 1, 19, 0, DateTimeKind.Unspecified), 17, new DateTime(2021, 11, 14, 5, 17, 31, 0, DateTimeKind.Unspecified) },
                    { 114, new DateTime(2021, 10, 26, 11, 54, 52, 0, DateTimeKind.Unspecified), 14, new DateTime(2021, 10, 14, 2, 49, 51, 0, DateTimeKind.Unspecified) },
                    { 133, new DateTime(2021, 11, 25, 7, 30, 32, 0, DateTimeKind.Unspecified), 8, new DateTime(2021, 11, 14, 2, 19, 44, 0, DateTimeKind.Unspecified) },
                    { 131, new DateTime(2021, 11, 21, 9, 23, 52, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 11, 8, 6, 0, 35, 0, DateTimeKind.Unspecified) },
                    { 78, new DateTime(2021, 10, 25, 7, 17, 22, 0, DateTimeKind.Unspecified), 78, new DateTime(2021, 10, 11, 9, 36, 11, 0, DateTimeKind.Unspecified) },
                    { 117, new DateTime(2021, 10, 9, 2, 53, 38, 0, DateTimeKind.Unspecified), 17, new DateTime(2021, 10, 25, 5, 54, 17, 0, DateTimeKind.Unspecified) },
                    { 118, new DateTime(2021, 10, 19, 8, 1, 52, 0, DateTimeKind.Unspecified), 18, new DateTime(2021, 10, 6, 6, 40, 58, 0, DateTimeKind.Unspecified) },
                    { 119, new DateTime(2021, 10, 6, 5, 9, 38, 0, DateTimeKind.Unspecified), 19, new DateTime(2021, 10, 21, 9, 57, 40, 0, DateTimeKind.Unspecified) },
                    { 120, new DateTime(2021, 10, 11, 9, 29, 40, 0, DateTimeKind.Unspecified), 20, new DateTime(2021, 10, 13, 11, 36, 9, 0, DateTimeKind.Unspecified) },
                    { 121, new DateTime(2021, 10, 5, 12, 36, 38, 0, DateTimeKind.Unspecified), 21, new DateTime(2021, 10, 29, 5, 42, 21, 0, DateTimeKind.Unspecified) },
                    { 132, new DateTime(2021, 11, 12, 2, 54, 36, 0, DateTimeKind.Unspecified), 7, new DateTime(2021, 11, 27, 4, 13, 13, 0, DateTimeKind.Unspecified) },
                    { 122, new DateTime(2021, 10, 5, 7, 8, 21, 0, DateTimeKind.Unspecified), 22, new DateTime(2021, 10, 5, 6, 24, 14, 0, DateTimeKind.Unspecified) },
                    { 124, new DateTime(2021, 10, 28, 9, 44, 41, 0, DateTimeKind.Unspecified), 24, new DateTime(2021, 10, 1, 9, 20, 38, 0, DateTimeKind.Unspecified) },
                    { 126, new DateTime(2021, 11, 12, 9, 5, 49, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 19, 3, 48, 42, 0, DateTimeKind.Unspecified) },
                    { 127, new DateTime(2021, 11, 29, 1, 5, 56, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 11, 11, 2, 19, 53, 0, DateTimeKind.Unspecified) },
                    { 128, new DateTime(2021, 11, 4, 10, 9, 36, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 4, 7, 36, 53, 0, DateTimeKind.Unspecified) },
                    { 129, new DateTime(2021, 11, 15, 11, 7, 17, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 11, 25, 6, 13, 8, 0, DateTimeKind.Unspecified) },
                    { 130, new DateTime(2021, 11, 12, 12, 20, 34, 0, DateTimeKind.Unspecified), 5, new DateTime(2021, 11, 8, 6, 9, 44, 0, DateTimeKind.Unspecified) },
                    { 123, new DateTime(2021, 10, 29, 8, 46, 47, 0, DateTimeKind.Unspecified), 23, new DateTime(2021, 10, 14, 10, 4, 42, 0, DateTimeKind.Unspecified) },
                    { 116, new DateTime(2021, 10, 13, 10, 40, 48, 0, DateTimeKind.Unspecified), 16, new DateTime(2021, 10, 26, 7, 7, 34, 0, DateTimeKind.Unspecified) },
                    { 77, new DateTime(2021, 10, 12, 8, 5, 44, 0, DateTimeKind.Unspecified), 77, new DateTime(2021, 10, 23, 1, 4, 25, 0, DateTimeKind.Unspecified) },
                    { 75, new DateTime(2021, 10, 28, 3, 26, 44, 0, DateTimeKind.Unspecified), 75, new DateTime(2021, 10, 18, 5, 33, 8, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2021, 7, 5, 2, 42, 15, 0, DateTimeKind.Unspecified), 21, new DateTime(2021, 7, 5, 9, 39, 37, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2021, 7, 5, 8, 58, 3, 0, DateTimeKind.Unspecified), 22, new DateTime(2021, 7, 22, 8, 36, 35, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2021, 7, 8, 7, 13, 14, 0, DateTimeKind.Unspecified), 23, new DateTime(2021, 7, 8, 5, 29, 58, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2021, 7, 18, 7, 29, 48, 0, DateTimeKind.Unspecified), 24, new DateTime(2021, 7, 12, 10, 44, 34, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2021, 8, 25, 10, 33, 34, 0, DateTimeKind.Unspecified), 25, new DateTime(2021, 8, 16, 2, 10, 54, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2021, 8, 18, 7, 19, 20, 0, DateTimeKind.Unspecified), 26, new DateTime(2021, 8, 23, 2, 59, 45, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2021, 8, 12, 7, 2, 50, 0, DateTimeKind.Unspecified), 27, new DateTime(2021, 8, 25, 12, 30, 29, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2021, 8, 22, 12, 38, 32, 0, DateTimeKind.Unspecified), 28, new DateTime(2021, 8, 10, 4, 22, 13, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2021, 8, 26, 8, 43, 24, 0, DateTimeKind.Unspecified), 29, new DateTime(2021, 8, 28, 11, 11, 44, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2021, 8, 21, 8, 3, 36, 0, DateTimeKind.Unspecified), 30, new DateTime(2021, 8, 13, 6, 23, 16, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2021, 8, 18, 4, 6, 3, 0, DateTimeKind.Unspecified), 31, new DateTime(2021, 8, 8, 5, 25, 36, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2021, 8, 16, 4, 6, 5, 0, DateTimeKind.Unspecified), 32, new DateTime(2021, 8, 15, 11, 16, 39, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2021, 8, 2, 2, 35, 19, 0, DateTimeKind.Unspecified), 33, new DateTime(2021, 8, 28, 10, 14, 32, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2021, 8, 8, 8, 58, 18, 0, DateTimeKind.Unspecified), 34, new DateTime(2021, 8, 29, 6, 39, 41, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2021, 8, 8, 2, 22, 36, 0, DateTimeKind.Unspecified), 35, new DateTime(2021, 8, 10, 4, 54, 20, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2021, 7, 28, 4, 48, 37, 0, DateTimeKind.Unspecified), 20, new DateTime(2021, 7, 14, 10, 36, 48, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2021, 8, 24, 12, 7, 15, 0, DateTimeKind.Unspecified), 36, new DateTime(2021, 8, 23, 5, 5, 30, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2021, 7, 28, 5, 56, 51, 0, DateTimeKind.Unspecified), 19, new DateTime(2021, 7, 5, 10, 23, 8, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2021, 7, 8, 6, 46, 37, 0, DateTimeKind.Unspecified), 17, new DateTime(2021, 7, 12, 9, 54, 49, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2021, 7, 28, 2, 38, 29, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 7, 23, 12, 56, 51, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2021, 7, 29, 4, 52, 35, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 7, 26, 8, 46, 23, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2021, 7, 3, 4, 45, 7, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 7, 27, 1, 13, 58, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2021, 7, 17, 4, 36, 25, 0, DateTimeKind.Unspecified), 5, new DateTime(2021, 7, 7, 2, 52, 27, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2021, 7, 1, 1, 45, 1, 0, DateTimeKind.Unspecified), 6, new DateTime(2021, 7, 27, 8, 47, 59, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2021, 7, 14, 1, 21, 57, 0, DateTimeKind.Unspecified), 7, new DateTime(2021, 7, 19, 7, 9, 43, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2021, 7, 27, 11, 29, 45, 0, DateTimeKind.Unspecified), 8, new DateTime(2021, 7, 5, 4, 28, 7, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2021, 7, 27, 4, 21, 39, 0, DateTimeKind.Unspecified), 9, new DateTime(2021, 7, 24, 7, 48, 50, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2021, 7, 6, 9, 36, 30, 0, DateTimeKind.Unspecified), 10, new DateTime(2021, 7, 4, 2, 48, 25, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2021, 7, 1, 8, 20, 13, 0, DateTimeKind.Unspecified), 11, new DateTime(2021, 7, 29, 9, 21, 9, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2021, 7, 29, 12, 49, 36, 0, DateTimeKind.Unspecified), 12, new DateTime(2021, 7, 12, 1, 37, 13, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2021, 7, 15, 1, 11, 38, 0, DateTimeKind.Unspecified), 13, new DateTime(2021, 7, 17, 8, 34, 49, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2021, 7, 9, 12, 25, 27, 0, DateTimeKind.Unspecified), 14, new DateTime(2021, 7, 5, 12, 3, 26, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2021, 7, 15, 3, 43, 54, 0, DateTimeKind.Unspecified), 15, new DateTime(2021, 7, 4, 8, 13, 23, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2021, 7, 29, 9, 4, 38, 0, DateTimeKind.Unspecified), 16, new DateTime(2021, 7, 26, 9, 53, 54, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2021, 7, 7, 12, 46, 27, 0, DateTimeKind.Unspecified), 18, new DateTime(2021, 7, 13, 6, 3, 22, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2021, 8, 9, 5, 5, 10, 0, DateTimeKind.Unspecified), 37, new DateTime(2021, 8, 5, 6, 25, 22, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2021, 8, 16, 12, 43, 39, 0, DateTimeKind.Unspecified), 38, new DateTime(2021, 8, 6, 6, 2, 49, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2021, 8, 27, 9, 28, 33, 0, DateTimeKind.Unspecified), 39, new DateTime(2021, 8, 24, 12, 21, 49, 0, DateTimeKind.Unspecified) },
                    { 60, new DateTime(2021, 9, 12, 1, 29, 48, 0, DateTimeKind.Unspecified), 60, new DateTime(2021, 9, 1, 2, 39, 54, 0, DateTimeKind.Unspecified) },
                    { 61, new DateTime(2021, 9, 13, 1, 51, 56, 0, DateTimeKind.Unspecified), 61, new DateTime(2021, 9, 1, 12, 37, 0, 0, DateTimeKind.Unspecified) },
                    { 62, new DateTime(2021, 9, 24, 12, 2, 55, 0, DateTimeKind.Unspecified), 62, new DateTime(2021, 9, 6, 4, 51, 59, 0, DateTimeKind.Unspecified) },
                    { 63, new DateTime(2021, 9, 25, 6, 50, 5, 0, DateTimeKind.Unspecified), 63, new DateTime(2021, 9, 8, 4, 35, 33, 0, DateTimeKind.Unspecified) },
                    { 64, new DateTime(2021, 9, 14, 2, 47, 14, 0, DateTimeKind.Unspecified), 64, new DateTime(2021, 9, 3, 9, 24, 2, 0, DateTimeKind.Unspecified) },
                    { 65, new DateTime(2021, 9, 22, 8, 41, 2, 0, DateTimeKind.Unspecified), 65, new DateTime(2021, 9, 8, 9, 44, 2, 0, DateTimeKind.Unspecified) },
                    { 66, new DateTime(2021, 9, 12, 7, 6, 22, 0, DateTimeKind.Unspecified), 66, new DateTime(2021, 9, 28, 6, 22, 51, 0, DateTimeKind.Unspecified) },
                    { 67, new DateTime(2021, 9, 14, 11, 2, 38, 0, DateTimeKind.Unspecified), 67, new DateTime(2021, 9, 11, 5, 31, 15, 0, DateTimeKind.Unspecified) },
                    { 68, new DateTime(2021, 9, 16, 11, 27, 28, 0, DateTimeKind.Unspecified), 68, new DateTime(2021, 9, 3, 5, 17, 10, 0, DateTimeKind.Unspecified) },
                    { 69, new DateTime(2021, 9, 8, 4, 30, 58, 0, DateTimeKind.Unspecified), 69, new DateTime(2021, 9, 9, 5, 29, 49, 0, DateTimeKind.Unspecified) },
                    { 70, new DateTime(2021, 9, 9, 9, 26, 35, 0, DateTimeKind.Unspecified), 70, new DateTime(2021, 9, 24, 8, 34, 34, 0, DateTimeKind.Unspecified) },
                    { 71, new DateTime(2021, 9, 13, 3, 49, 50, 0, DateTimeKind.Unspecified), 71, new DateTime(2021, 9, 29, 3, 54, 18, 0, DateTimeKind.Unspecified) },
                    { 72, new DateTime(2021, 9, 14, 11, 16, 47, 0, DateTimeKind.Unspecified), 72, new DateTime(2021, 9, 14, 5, 52, 11, 0, DateTimeKind.Unspecified) },
                    { 73, new DateTime(2021, 9, 29, 9, 36, 3, 0, DateTimeKind.Unspecified), 73, new DateTime(2021, 9, 5, 10, 41, 53, 0, DateTimeKind.Unspecified) },
                    { 74, new DateTime(2021, 9, 23, 2, 23, 37, 0, DateTimeKind.Unspecified), 74, new DateTime(2021, 9, 8, 7, 31, 24, 0, DateTimeKind.Unspecified) },
                    { 59, new DateTime(2021, 9, 26, 1, 14, 14, 0, DateTimeKind.Unspecified), 59, new DateTime(2021, 9, 21, 11, 15, 8, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(2021, 9, 26, 4, 25, 58, 0, DateTimeKind.Unspecified), 58, new DateTime(2021, 9, 13, 9, 5, 54, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(2021, 9, 16, 2, 16, 44, 0, DateTimeKind.Unspecified), 57, new DateTime(2021, 9, 4, 4, 9, 4, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(2021, 9, 18, 12, 18, 11, 0, DateTimeKind.Unspecified), 56, new DateTime(2021, 9, 25, 8, 12, 42, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2021, 8, 24, 6, 2, 24, 0, DateTimeKind.Unspecified), 40, new DateTime(2021, 8, 29, 1, 35, 3, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(2021, 8, 12, 8, 43, 23, 0, DateTimeKind.Unspecified), 41, new DateTime(2021, 8, 13, 4, 0, 9, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2021, 8, 22, 12, 12, 31, 0, DateTimeKind.Unspecified), 42, new DateTime(2021, 8, 16, 11, 13, 34, 0, DateTimeKind.Unspecified) },
                    { 43, new DateTime(2021, 8, 11, 1, 42, 34, 0, DateTimeKind.Unspecified), 43, new DateTime(2021, 8, 10, 2, 39, 21, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2021, 8, 12, 10, 16, 17, 0, DateTimeKind.Unspecified), 44, new DateTime(2021, 8, 24, 6, 48, 16, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2021, 8, 13, 8, 28, 10, 0, DateTimeKind.Unspecified), 45, new DateTime(2021, 8, 8, 11, 24, 59, 0, DateTimeKind.Unspecified) },
                    { 46, new DateTime(2021, 8, 25, 6, 33, 21, 0, DateTimeKind.Unspecified), 46, new DateTime(2021, 8, 2, 4, 47, 50, 0, DateTimeKind.Unspecified) },
                    { 76, new DateTime(2021, 10, 12, 12, 5, 17, 0, DateTimeKind.Unspecified), 76, new DateTime(2021, 10, 19, 1, 4, 32, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(2021, 8, 11, 3, 28, 24, 0, DateTimeKind.Unspecified), 47, new DateTime(2021, 8, 15, 3, 50, 9, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(2021, 8, 20, 7, 42, 32, 0, DateTimeKind.Unspecified), 49, new DateTime(2021, 8, 23, 6, 39, 14, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2021, 9, 20, 10, 10, 8, 0, DateTimeKind.Unspecified), 50, new DateTime(2021, 9, 11, 7, 36, 30, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(2021, 9, 26, 9, 4, 20, 0, DateTimeKind.Unspecified), 51, new DateTime(2021, 9, 15, 11, 51, 31, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(2021, 9, 17, 5, 22, 41, 0, DateTimeKind.Unspecified), 52, new DateTime(2021, 9, 6, 7, 14, 33, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(2021, 9, 24, 5, 24, 14, 0, DateTimeKind.Unspecified), 53, new DateTime(2021, 9, 25, 2, 1, 38, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(2021, 9, 12, 5, 43, 48, 0, DateTimeKind.Unspecified), 54, new DateTime(2021, 9, 9, 8, 0, 9, 0, DateTimeKind.Unspecified) },
                    { 55, new DateTime(2021, 9, 10, 3, 30, 57, 0, DateTimeKind.Unspecified), 55, new DateTime(2021, 9, 10, 7, 28, 10, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(2021, 8, 16, 9, 7, 55, 0, DateTimeKind.Unspecified), 48, new DateTime(2021, 8, 1, 10, 35, 19, 0, DateTimeKind.Unspecified) },
                    { 1, new DateTime(2021, 7, 12, 4, 54, 24, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 7, 3, 11, 36, 34, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "1f28d4c8-1edc-4b49-a4be-bafd7b79f351", new DateTime(2021, 9, 17, 0, 9, 7, 469, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "496a836f-a8a9-4596-a4ce-78eef14bd11f", new DateTime(2021, 9, 17, 0, 9, 7, 469, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "0e0a1877-b3a4-47c4-95b1-e4311b5498f0", new DateTime(2021, 9, 17, 0, 9, 7, 469, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "7f7bfb21-f8f5-40b3-952e-29fe0875e41a", new DateTime(2021, 9, 17, 0, 9, 7, 468, DateTimeKind.Local).AddTicks(8709), new DateTime(2021, 9, 17, 0, 9, 7, 461, DateTimeKind.Local).AddTicks(4949), "AQAAAAEAACcQAAAAEBOFkqJjB5+6QHZFoowwluyDouCYnP0glNEXTGsd96MgUsrF1Sn+q+EdTMOKPbd4tw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "b173842c-881b-445c-b8f0-c4e31807e71f", new DateTime(2021, 9, 17, 0, 9, 7, 461, DateTimeKind.Local).AddTicks(4936), new DateTime(2021, 9, 17, 0, 9, 7, 453, DateTimeKind.Local).AddTicks(9816), "AQAAAAEAACcQAAAAELwHbzHu4QzRNenji8aECQ0Imdd4qpJ8E/i/Mh+E+XrytYgnbd+UvCsdHxjG+dmzhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "fbe3a94a-19c4-4344-845a-8af015170235", new DateTime(2021, 9, 17, 0, 9, 7, 453, DateTimeKind.Local).AddTicks(9233), new DateTime(2021, 9, 17, 0, 9, 7, 443, DateTimeKind.Local).AddTicks(8733), "AQAAAAEAACcQAAAAENelOV4pFefS91Fa2Ah/TwCi8uwIfxPXFsuB78fkWuzXypwK155YkRNfLxkmFi31yA==" });
        }
    }
}
