using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class SeedUpdateAddedActorsInMoviesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 911, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 911, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 911, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 911, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 911, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 911, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 911, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 911, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 911, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 911, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.InsertData(
                table: "ActorsInMovies",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[,]
                {
                    { -39, -8, -20 },
                    { -38, -5, -19 },
                    { -37, -3, -19 },
                    { -1, -1, -1 },
                    { -35, -9, -18 },
                    { -34, -6, -17 },
                    { -40, -9, -20 },
                    { -36, -10, -18 },
                    { -41, -2, -21 },
                    { -48, -5, -24 },
                    { -43, -6, -22 },
                    { -44, -7, -22 },
                    { -45, -9, -23 },
                    { -47, -2, -24 },
                    { -33, -2, -17 },
                    { -49, -8, -22 },
                    { -50, -9, -24 },
                    { -51, -1, -16 },
                    { -42, -4, -21 },
                    { -32, -3, -16 },
                    { -46, -1, -23 },
                    { -30, -9, -15 },
                    { -31, -10, -15 },
                    { -3, -2, -2 },
                    { -4, -3, -2 },
                    { -5, -1, -3 },
                    { -6, -5, -3 },
                    { -7, -6, -4 },
                    { -8, -7, -4 },
                    { -9, -8, -4 },
                    { -10, -9, -5 },
                    { -11, -10, -5 },
                    { -12, -1, -6 },
                    { -13, -2, -6 },
                    { -14, -3, -7 },
                    { -15, -4, -7 },
                    { -2, -2, -1 },
                    { -26, -5, -13 },
                    { -29, -8, -14 },
                    { -28, -7, -14 },
                    { -27, -6, -13 },
                    { -25, -4, -12 },
                    { -24, -3, -12 },
                    { -23, -2, -11 },
                    { -16, -5, -8 },
                    { -21, -10, -10 },
                    { -20, -9, -10 },
                    { -19, -8, -9 },
                    { -18, -7, -9 },
                    { -17, -6, -8 },
                    { -22, -1, -11 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "29a55c6b-de30-495f-9744-aa1993f003d7", new DateTime(2021, 9, 5, 23, 14, 12, 910, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "cc6252ae-0cb7-401a-b411-f01b5f450d24", new DateTime(2021, 9, 5, 23, 14, 12, 910, DateTimeKind.Local).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "cea6b2e6-81e3-4b5f-98a2-546eec54fda3", new DateTime(2021, 9, 5, 23, 14, 12, 909, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "fb47c7ce-2af6-4525-ad84-d9ef6ef39d40", new DateTime(2021, 9, 5, 23, 14, 12, 908, DateTimeKind.Local).AddTicks(8471), new DateTime(2021, 9, 5, 23, 14, 12, 900, DateTimeKind.Local).AddTicks(9422), "AQAAAAEAACcQAAAAEDm6I4cudah2K9v6vRGFATCvPpLPq30q1uM9cpfWJeLZPkECBP+3CGaTgej5V5u4Xg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "bc5a1cd8-9c2c-4765-9e10-438857042569", new DateTime(2021, 9, 5, 23, 14, 12, 900, DateTimeKind.Local).AddTicks(9410), new DateTime(2021, 9, 5, 23, 14, 12, 893, DateTimeKind.Local).AddTicks(5296), "AQAAAAEAACcQAAAAEIx++gkmvLnYis9/L0ZOuo7EnbCyEv+5hZOFrissLVlQrPxvToVmiqZJp2otJOwJfg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "8467eb43-0623-4594-a7ef-b3fd3ff82bdd", new DateTime(2021, 9, 5, 23, 14, 12, 893, DateTimeKind.Local).AddTicks(4704), new DateTime(2021, 9, 5, 23, 14, 12, 883, DateTimeKind.Local).AddTicks(3761), "AQAAAAEAACcQAAAAEEoY+lhOhnac5ZrnmJU/wiBvNu/Y9BoDNRCscliBxnXP6iTxTn0V/0nnboCGYT+8eA==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 14, 12, 913, DateTimeKind.Local).AddTicks(6547));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "1dbaee7b-d9ce-4c12-981d-a5d93915139b", new DateTime(2021, 9, 5, 22, 56, 24, 270, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "d1a48e3a-284f-4863-b1f7-ae4c72bdb79e", new DateTime(2021, 9, 5, 22, 56, 24, 270, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "37f1d88f-da32-49f1-868b-2895798e5aa3", new DateTime(2021, 9, 5, 22, 56, 24, 270, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "7a5a0d39-355c-4290-ac66-a089fe6e697c", new DateTime(2021, 9, 5, 22, 56, 24, 269, DateTimeKind.Local).AddTicks(6638), new DateTime(2021, 9, 5, 22, 56, 24, 261, DateTimeKind.Local).AddTicks(5326), "AQAAAAEAACcQAAAAEFLiZxTsJ5nNCEIRPohtXCSDFd5eDwqQLNY3GttHFBGsW1bkqkigPuVje2ofW0hNqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "3fcb0327-f9d7-4882-bc0a-07f8d717c343", new DateTime(2021, 9, 5, 22, 56, 24, 261, DateTimeKind.Local).AddTicks(5314), new DateTime(2021, 9, 5, 22, 56, 24, 253, DateTimeKind.Local).AddTicks(3572), "AQAAAAEAACcQAAAAEDHpWmUQgMTLm1gr9lD8HpRIM6j7cisn1XljPuBz610/+xCj9m1clPYv9SjZ/gxYng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "c019aee6-62fb-491c-bda1-84660a8e0371", new DateTime(2021, 9, 5, 22, 56, 24, 253, DateTimeKind.Local).AddTicks(2860), new DateTime(2021, 9, 5, 22, 56, 24, 239, DateTimeKind.Local).AddTicks(4080), "AQAAAAEAACcQAAAAENKK2T3pm4ozO1Jre+BSLFituUTO29rC7xglJTxeOFXaj/RAanSylEcY7w3V81RyXw==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(251));
        }
    }
}
