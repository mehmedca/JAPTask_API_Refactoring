using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class PhotoIdChangedToNullableInMoviesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "Movies",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 594, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 594, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 594, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 594, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 594, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 594, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 594, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 594, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 594, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 594, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "6cce069f-1d09-4e4d-bde1-e16a9a01046d", new DateTime(2021, 9, 5, 23, 59, 23, 592, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "9db60703-58dc-42b7-9090-32628ea19f79", new DateTime(2021, 9, 5, 23, 59, 23, 592, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "212cec95-7922-4f88-bdb5-7775deb06de5", new DateTime(2021, 9, 5, 23, 59, 23, 592, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "8476d926-778d-4612-b8c1-5a8142f59055", new DateTime(2021, 9, 5, 23, 59, 23, 591, DateTimeKind.Local).AddTicks(7851), new DateTime(2021, 9, 5, 23, 59, 23, 584, DateTimeKind.Local).AddTicks(4069), "AQAAAAEAACcQAAAAEAUStNWn/ttglJCLRr9JI9STIrpgh2N5Wnes/auP8QzTbX3Vhvp5cKUfUUP0LDQhww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "2ae70775-e9e3-4746-a178-956552925414", new DateTime(2021, 9, 5, 23, 59, 23, 584, DateTimeKind.Local).AddTicks(4052), new DateTime(2021, 9, 5, 23, 59, 23, 576, DateTimeKind.Local).AddTicks(9537), "AQAAAAEAACcQAAAAENn006wofI/akR3oHfsyVbZ6u3NOUC5mYL9ZzAc5XAeeEY4nS5TkrPsR4+QMv0I8QQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "c2a20118-a38d-458f-b021-cab363d884f0", new DateTime(2021, 9, 5, 23, 59, 23, 576, DateTimeKind.Local).AddTicks(8961), new DateTime(2021, 9, 5, 23, 59, 23, 567, DateTimeKind.Local).AddTicks(1462), "AQAAAAEAACcQAAAAEBWuy7Q49IurOh8rlsphOIKA8ICiDJcTOKiVpqdWJwyINguZywYJQmhgVxznPSMDgA==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 23, 59, 23, 596, DateTimeKind.Local).AddTicks(6359));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "Movies",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

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
    }
}
