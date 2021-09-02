using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "DateModified", "Email", "EmailConfirmed", "FirstName", "LastName", "LastOnline", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "rOFHG9xvlRKAdXOjUh3J", 0, "516994a9-7ef2-4ded-8677-e30ee59c6a8f", new DateTime(2021, 9, 3, 0, 11, 57, 197, DateTimeKind.Local).AddTicks(6376), null, null, false, "Admin", "Admin", new DateTime(2021, 9, 3, 0, 11, 57, 182, DateTimeKind.Local).AddTicks(4668), false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEMOdk82C3202fMZfRGBiYuITpQY5AEPK4G9ibtsMY5EIYrukXL6XzHH/LSmAA3AE6A==", null, false, null, null, false, "admin" },
                    { "pQVqvZg7tnJYQv93gme9", 0, "4f16d190-7bf8-49ca-bc77-61748f9802d1", new DateTime(2021, 9, 3, 0, 11, 57, 205, DateTimeKind.Local).AddTicks(4506), null, null, false, "Moderator", "Moderator", new DateTime(2021, 9, 3, 0, 11, 57, 197, DateTimeKind.Local).AddTicks(7429), false, null, null, "MODERATOR", "AQAAAAEAACcQAAAAEBdFkEmiVdXnPM4iccjzWIZh29aRYUr7etOYj0CJK5064OyvYMS5LD1Q1+Xt3euQqQ==", null, false, null, null, false, "moderator" },
                    { "NsOUTyrRU3CRxdPY06lP", 0, "390b5c49-b0f7-4608-9110-eb29f27b8610", new DateTime(2021, 9, 3, 0, 11, 57, 213, DateTimeKind.Local).AddTicks(830), null, null, false, "User", "User", new DateTime(2021, 9, 3, 0, 11, 57, 205, DateTimeKind.Local).AddTicks(4521), false, null, null, "USER", "AQAAAAEAACcQAAAAEF1tId/IOpXzAvJWeUYSOsF7bIpRgtN+XxK7IyYqoZTOZ9gZzRMBzgAf6UyJpyGZ1g==", null, false, null, null, false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedById", "DateCreated", "DateDeleted", "DateModified", "DeletedById", "IsDeleted", "ModifiedById", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8cdd8900-b5a2-41ef-bd55-2a4215f04c48", "a23b7936-33b6-4360-b436-2c737f631d43", "rOFHG9xvlRKAdXOjUh3J", new DateTime(2021, 9, 3, 0, 11, 57, 214, DateTimeKind.Local).AddTicks(2464), null, null, null, false, null, "Admin", "ADMIN" },
                    { "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397", "e0361e6d-eec0-40a5-a0ab-2d913a632ed1", "rOFHG9xvlRKAdXOjUh3J", new DateTime(2021, 9, 3, 0, 11, 57, 214, DateTimeKind.Local).AddTicks(2884), null, null, null, false, null, "Moderator", "MODERATOR" },
                    { "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0", "70736a79-2fd3-4731-accd-20c7d5b3e8c7", "rOFHG9xvlRKAdXOjUh3J", new DateTime(2021, 9, 3, 0, 11, 57, 214, DateTimeKind.Local).AddTicks(2906), null, null, null, false, null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8cdd8900-b5a2-41ef-bd55-2a4215f04c48", "rOFHG9xvlRKAdXOjUh3J" },
                    { "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397", "pQVqvZg7tnJYQv93gme9" },
                    { "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0", "NsOUTyrRU3CRxdPY06lP" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0", "NsOUTyrRU3CRxdPY06lP" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397", "pQVqvZg7tnJYQv93gme9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8cdd8900-b5a2-41ef-bd55-2a4215f04c48", "rOFHG9xvlRKAdXOjUh3J" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J");
        }
    }
}
