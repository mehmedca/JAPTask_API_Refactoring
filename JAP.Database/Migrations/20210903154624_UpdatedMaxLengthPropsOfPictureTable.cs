using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class UpdatedMaxLengthPropsOfPictureTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Photos",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "PublicId",
                table: "Photos",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "8dfa82ce-8054-4b68-b865-dcc69be1bcb2", new DateTime(2021, 9, 3, 17, 46, 23, 858, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "d2125470-f9be-44c8-a04f-a8a1fd157fd2", new DateTime(2021, 9, 3, 17, 46, 23, 858, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "8fa4a5b6-00e7-4ce3-a5f4-ed0b5208b782", new DateTime(2021, 9, 3, 17, 46, 23, 858, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "f8eaeee9-5939-465f-9914-ee71503cb79c", new DateTime(2021, 9, 3, 17, 46, 23, 857, DateTimeKind.Local).AddTicks(3600), new DateTime(2021, 9, 3, 17, 46, 23, 849, DateTimeKind.Local).AddTicks(9879), "AQAAAAEAACcQAAAAEHfI3zcVMsdgiXGk3mktLhRMWpNUWbGHQq4PpIQLiceCo6l65Uf3DXbdvLt19XhqZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "7d491e06-ff0c-4b9c-aa08-efd089ea9694", new DateTime(2021, 9, 3, 17, 46, 23, 849, DateTimeKind.Local).AddTicks(9861), new DateTime(2021, 9, 3, 17, 46, 23, 842, DateTimeKind.Local).AddTicks(4853), "AQAAAAEAACcQAAAAEPVtzsZtSl33U71pb4jIYe85jbftLfZJd4lZqFknkkepnW9g5/Iq+PYAjiDLJ72Wpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "bdb2ce19-daef-41d5-b1d2-a2cff768d9e2", new DateTime(2021, 9, 3, 17, 46, 23, 842, DateTimeKind.Local).AddTicks(4268), new DateTime(2021, 9, 3, 17, 46, 23, 832, DateTimeKind.Local).AddTicks(2841), "AQAAAAEAACcQAAAAEN7f37bb3llboyttKJCriEQziPEeYiSmwZ3UAiBdGMcAexoHsptmNvpZ1dirKu17Xw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Photos",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "PublicId",
                table: "Photos",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "70736a79-2fd3-4731-accd-20c7d5b3e8c7", new DateTime(2021, 9, 3, 0, 11, 57, 214, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "e0361e6d-eec0-40a5-a0ab-2d913a632ed1", new DateTime(2021, 9, 3, 0, 11, 57, 214, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "a23b7936-33b6-4360-b436-2c737f631d43", new DateTime(2021, 9, 3, 0, 11, 57, 214, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "390b5c49-b0f7-4608-9110-eb29f27b8610", new DateTime(2021, 9, 3, 0, 11, 57, 213, DateTimeKind.Local).AddTicks(830), new DateTime(2021, 9, 3, 0, 11, 57, 205, DateTimeKind.Local).AddTicks(4521), "AQAAAAEAACcQAAAAEF1tId/IOpXzAvJWeUYSOsF7bIpRgtN+XxK7IyYqoZTOZ9gZzRMBzgAf6UyJpyGZ1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "4f16d190-7bf8-49ca-bc77-61748f9802d1", new DateTime(2021, 9, 3, 0, 11, 57, 205, DateTimeKind.Local).AddTicks(4506), new DateTime(2021, 9, 3, 0, 11, 57, 197, DateTimeKind.Local).AddTicks(7429), "AQAAAAEAACcQAAAAEBdFkEmiVdXnPM4iccjzWIZh29aRYUr7etOYj0CJK5064OyvYMS5LD1Q1+Xt3euQqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "516994a9-7ef2-4ded-8677-e30ee59c6a8f", new DateTime(2021, 9, 3, 0, 11, 57, 197, DateTimeKind.Local).AddTicks(6376), new DateTime(2021, 9, 3, 0, 11, 57, 182, DateTimeKind.Local).AddTicks(4668), "AQAAAAEAACcQAAAAEMOdk82C3202fMZfRGBiYuITpQY5AEPK4G9ibtsMY5EIYrukXL6XzHH/LSmAA3AE6A==" });
        }
    }
}
