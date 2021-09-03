using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class SeedPhotosToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "0a329d69-8e6e-4082-80a1-1c052447e36c", new DateTime(2021, 9, 3, 17, 48, 33, 225, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "b78440a5-da05-48d2-a8f9-70e29f7ea6fe", new DateTime(2021, 9, 3, 17, 48, 33, 225, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "8c9298d0-b2fa-459b-869c-e5a818022e52", new DateTime(2021, 9, 3, 17, 48, 33, 225, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "6456c7d4-207a-41a7-a00b-97bcb4248233", new DateTime(2021, 9, 3, 17, 48, 33, 224, DateTimeKind.Local).AddTicks(6692), new DateTime(2021, 9, 3, 17, 48, 33, 217, DateTimeKind.Local).AddTicks(1648), "AQAAAAEAACcQAAAAEK9gHGo11bG4pKZEY1koUF7cEf1F+CLh50CBwnmFKpI01IvOSAq9uT+XD6BhR7OGlw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "2405bd71-f52d-4706-b798-d09705cd5fdf", new DateTime(2021, 9, 3, 17, 48, 33, 217, DateTimeKind.Local).AddTicks(1631), new DateTime(2021, 9, 3, 17, 48, 33, 209, DateTimeKind.Local).AddTicks(4746), "AQAAAAEAACcQAAAAEDg6gmbnDxTSw5p1YD+BdDCO1ILncXKurz5v1fBR2bKhsm2ICzc7CMopz/r/07hpug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "f43e18fc-be19-46c3-8685-cef8574f746d", new DateTime(2021, 9, 3, 17, 48, 33, 209, DateTimeKind.Local).AddTicks(4162), new DateTime(2021, 9, 3, 17, 48, 33, 199, DateTimeKind.Local).AddTicks(4214), "AQAAAAEAACcQAAAAEB2L8gu1Fond/1x2n1fZDtCtoxh/YzcWrifqx/txNzaaGs6H2DVN4diPn6txaNUkqA==" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "PublicId", "Url" },
                values: new object[,]
                {
                    { -11, "darkknight_uxmvzc", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675786/darkknight_uxmvzc.jpg" },
                    { -10, "mrandmrssmith_cstx0w", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675786/mrandmrssmith_cstx0w.jpg" },
                    { -9, "suicidesquad_eq8mih", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675786/suicidesquad_eq8mih.jpg" },
                    { -7, "hitandrun_ezk6zp", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675787/hitandrun_ezk6zp.jpg" },
                    { -6, "bradpitt_zo0pcb", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676129/bradpitt_zo0pcb.jpg" },
                    { -5, "scarlettjohanson_rkcu5u", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676129/scarlettjohanson_rkcu5u.jpg" },
                    { -4, "natalieportman_i6vuot", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676130/natalieportman_i6vuot.jpg" },
                    { -3, "tomhanks_hva0vj", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676130/tomhanks_hva0vj.jpg" },
                    { -2, "angelinajolie_xjbhe7", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676126/angelinajolie_xjbhe7.jpg" },
                    { -8, "thegodfather_aumlac", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630675787/thegodfather_aumlac.jpg" },
                    { -1, "johnnydepp_iora25", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630676131/johnnydepp_iora25.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -1);

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
    }
}
