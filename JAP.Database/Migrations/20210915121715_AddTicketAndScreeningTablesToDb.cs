using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JAP.Database.Migrations
{
    public partial class AddTicketAndScreeningTablesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screenings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    ScreeningId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Screenings_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MovieId",
                table: "Screenings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ScreeningId",
                table: "Tickets",
                column: "ScreeningId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 755, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "10c07a73-dd7a-4b00-a7f6-ce902e096012", new DateTime(2021, 9, 9, 1, 37, 37, 752, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "66d1cb3b-cf68-43ab-b4cd-0f1d25baf329", new DateTime(2021, 9, 9, 1, 37, 37, 752, DateTimeKind.Local).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "dc65f26b-2de8-4c73-b4ca-46c8e4788cda", new DateTime(2021, 9, 9, 1, 37, 37, 752, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "cb739352-91df-4bcb-9dd6-9e000e0e2d4e", new DateTime(2021, 9, 9, 1, 37, 37, 750, DateTimeKind.Local).AddTicks(5197), new DateTime(2021, 9, 9, 1, 37, 37, 740, DateTimeKind.Local).AddTicks(1740), "AQAAAAEAACcQAAAAEINM29npV9dDldhS3We6OGp0j7AV7ykxIK6ITWPBmyxDcr0/9z3aTWbRn4AuRx6ArA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "831a9f80-007a-4730-8a5b-2c9a351a2eaa", new DateTime(2021, 9, 9, 1, 37, 37, 740, DateTimeKind.Local).AddTicks(1670), new DateTime(2021, 9, 9, 1, 37, 37, 726, DateTimeKind.Local).AddTicks(932), "AQAAAAEAACcQAAAAEC6eS25PZe7LQGb9In/l+eGanB3BYnRLnnjTCDkpWfKaKCaRrMHgEnYUNvwjn95OLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "4e5a83bf-8e6c-4b44-abde-9747febf577f", new DateTime(2021, 9, 9, 1, 37, 37, 725, DateTimeKind.Local).AddTicks(9399), new DateTime(2021, 9, 9, 1, 37, 37, 706, DateTimeKind.Local).AddTicks(2897), "AQAAAAEAACcQAAAAEAiYWBh05qY76iCjfdkVA4+EPFvn8d+GkUWCdiOlCZk5dFgSAN0h3vFlwtIFcAn32g==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 1, 37, 37, 757, DateTimeKind.Local).AddTicks(4466));
        }
    }
}
