using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class PhotoIdChangedToNullableInActorsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "Actors",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 422, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "dd314dc5-64c5-42bb-8839-9a943eecd299", new DateTime(2021, 9, 6, 0, 20, 13, 420, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "d74a384d-937a-4cdd-be04-65a1ea869b30", new DateTime(2021, 9, 6, 0, 20, 13, 420, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "518a1092-8991-406f-bcce-b13cca6a2ec6", new DateTime(2021, 9, 6, 0, 20, 13, 420, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "681ac9ef-dd94-42b3-be57-42263551c86f", new DateTime(2021, 9, 6, 0, 20, 13, 419, DateTimeKind.Local).AddTicks(5615), new DateTime(2021, 9, 6, 0, 20, 13, 412, DateTimeKind.Local).AddTicks(949), "AQAAAAEAACcQAAAAELFltfcsghV/kFf9TTRcTg6pGiuDjEYg6kZwdHiDBq95Ts2PyAjSsNzWUJHggH93bw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "2d43c2c0-9f87-4abb-99c2-4deabdcbe61c", new DateTime(2021, 9, 6, 0, 20, 13, 412, DateTimeKind.Local).AddTicks(935), new DateTime(2021, 9, 6, 0, 20, 13, 404, DateTimeKind.Local).AddTicks(4236), "AQAAAAEAACcQAAAAEFJSCdG/kuEzuwFt5U+aKDw/6LlyC467iMcCDcylOH4rEh0C/1n61t8HmleuD/TIMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "997e3fbb-a914-4260-b8ea-e9daa5f42599", new DateTime(2021, 9, 6, 0, 20, 13, 404, DateTimeKind.Local).AddTicks(3658), new DateTime(2021, 9, 6, 0, 20, 13, 394, DateTimeKind.Local).AddTicks(3874), "AQAAAAEAACcQAAAAENQ7xiCkYfbO5gBpRWSEj9QFUlH5CQwkbfsC2yBOrdOe8MAFxcrO//0CHTxlloEhtA==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 0, 20, 13, 424, DateTimeKind.Local).AddTicks(4214));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "Actors",
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
    }
}
