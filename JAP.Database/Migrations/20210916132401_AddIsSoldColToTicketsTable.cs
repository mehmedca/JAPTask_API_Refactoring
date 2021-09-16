using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class AddIsSoldColToTicketsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSold",
                table: "Tickets",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSold",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 752, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 752, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 752, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 752, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 752, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 752, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 752, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 752, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 752, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 752, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "34a07f01-8ec6-4124-923c-74d875bfa03a", new DateTime(2021, 9, 15, 14, 17, 14, 750, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "6bf72e6e-6093-491f-ab50-c251c1567243", new DateTime(2021, 9, 15, 14, 17, 14, 750, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "4b202124-cd07-4aec-8506-284b067d2920", new DateTime(2021, 9, 15, 14, 17, 14, 750, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "cf2e7fb4-75e8-4981-bf69-15ff4a4c0e01", new DateTime(2021, 9, 15, 14, 17, 14, 749, DateTimeKind.Local).AddTicks(6791), new DateTime(2021, 9, 15, 14, 17, 14, 742, DateTimeKind.Local).AddTicks(3045), "AQAAAAEAACcQAAAAECGwrPXTQDFkNXlVL0h1HkwmLIFgAWgIhofxhHer/H4mWYOZ/OZez5zlsGwiq7tz4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "a41101e0-9d56-4dea-b9c5-4cf81178d85d", new DateTime(2021, 9, 15, 14, 17, 14, 742, DateTimeKind.Local).AddTicks(3033), new DateTime(2021, 9, 15, 14, 17, 14, 734, DateTimeKind.Local).AddTicks(8946), "AQAAAAEAACcQAAAAEOzXCNhiKyX+6qTEso3lFeD1ZsUkD5Y60IY67knjJnzgm4arGCKYA4Kl4UJRlGiyuQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "43b2e0af-2039-4597-bbf1-03763e3b76c8", new DateTime(2021, 9, 15, 14, 17, 14, 734, DateTimeKind.Local).AddTicks(8369), new DateTime(2021, 9, 15, 14, 17, 14, 724, DateTimeKind.Local).AddTicks(7139), "AQAAAAEAACcQAAAAENk0WtfYV/HPzA2NJ39UsxiBwXJ74V0U09mu0p6d5nmjdLfX55hoiJctxBetPHIU4Q==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 17, 14, 754, DateTimeKind.Local).AddTicks(4337));
        }
    }
}
