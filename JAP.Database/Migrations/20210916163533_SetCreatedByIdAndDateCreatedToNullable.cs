using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class SetCreatedByIdAndDateCreatedToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Movies",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Movies",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Actors",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Actors",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 269, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 269, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 269, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 269, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 269, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 269, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 269, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 269, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 269, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 269, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "6599d9f3-1b26-4e46-9912-df3a0dc3fbff", new DateTime(2021, 9, 16, 18, 35, 32, 267, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "73e4c8a2-da5f-4dc5-bcbc-2c545a693584", new DateTime(2021, 9, 16, 18, 35, 32, 267, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "6d1ed24f-a841-41fa-a66d-143fe538b3c4", new DateTime(2021, 9, 16, 18, 35, 32, 267, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "9f306fa8-d520-4bc1-90f6-1a28aa991e9c", new DateTime(2021, 9, 16, 18, 35, 32, 266, DateTimeKind.Local).AddTicks(7481), new DateTime(2021, 9, 16, 18, 35, 32, 259, DateTimeKind.Local).AddTicks(9209), "AQAAAAEAACcQAAAAEC3OxlctUME4XBHWiLJHLpysPS2C6/Xa4/Rln+WYwAUMXrolnS1D2yobwTkIi5V7FQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "735d9191-8d9c-469f-bb32-b81fc4a8f5e1", new DateTime(2021, 9, 16, 18, 35, 32, 259, DateTimeKind.Local).AddTicks(9198), new DateTime(2021, 9, 16, 18, 35, 32, 252, DateTimeKind.Local).AddTicks(9422), "AQAAAAEAACcQAAAAEKTzI6QOL9UtopPp9tt7hUfdMailT3YrQQ6bXmc1b8iEUxkMZ4DAOU+BjmS5EzdExA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "243353d9-7e31-453a-8ce7-64fc91ae9117", new DateTime(2021, 9, 16, 18, 35, 32, 252, DateTimeKind.Local).AddTicks(8888), new DateTime(2021, 9, 16, 18, 35, 32, 243, DateTimeKind.Local).AddTicks(2324), "AQAAAAEAACcQAAAAEIC9JOfCTM9KceLWE3ecyzFmdtvE+PyJxteII+6OSOx6xSrZc7qbG0Vx76x2oWHrGQ==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 272, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 18, 35, 32, 271, DateTimeKind.Local).AddTicks(8661));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Movies",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Movies",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Actors",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
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
                table: "Actors",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 314, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 314, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 314, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 314, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 314, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 314, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 314, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 314, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 314, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 314, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "0b870f0a-6514-48b5-9cfd-3cca618f1616", new DateTime(2021, 9, 16, 15, 24, 0, 312, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "975b203c-1607-48ca-98be-5780a14f5d3b", new DateTime(2021, 9, 16, 15, 24, 0, 312, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "8c049094-07d0-469c-8e45-ebccce841d5e", new DateTime(2021, 9, 16, 15, 24, 0, 312, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "77a66295-1110-43be-99d2-9e48952ce67c", new DateTime(2021, 9, 16, 15, 24, 0, 311, DateTimeKind.Local).AddTicks(955), new DateTime(2021, 9, 16, 15, 24, 0, 303, DateTimeKind.Local).AddTicks(4772), "AQAAAAEAACcQAAAAEAJlWJkewWlkQ9FZBOIrlRLZPhQYWUJSZOx2j3UIgpnp1pQHpwLq9GzjykKYcyr5UQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "396080ac-3315-4e7f-8d2c-3efea38cba93", new DateTime(2021, 9, 16, 15, 24, 0, 303, DateTimeKind.Local).AddTicks(4757), new DateTime(2021, 9, 16, 15, 24, 0, 295, DateTimeKind.Local).AddTicks(8024), "AQAAAAEAACcQAAAAEApNjVIkexD6M54FZaMTzq88gixFCFJfQhJH5xYac6xe9KfVKvzKeo6PHexUNJFgyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "7c210843-0823-45a3-86a8-02701a06bf63", new DateTime(2021, 9, 16, 15, 24, 0, 295, DateTimeKind.Local).AddTicks(6973), new DateTime(2021, 9, 16, 15, 24, 0, 285, DateTimeKind.Local).AddTicks(5962), "AQAAAAEAACcQAAAAEOt8E3LZ686b8qr7KaiwR+ftJtQg1TBfSjBEwk4hp99qmoUsHoZgXHfH+IoBROdZEw==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 15, 24, 0, 316, DateTimeKind.Local).AddTicks(1809));
        }
    }
}
