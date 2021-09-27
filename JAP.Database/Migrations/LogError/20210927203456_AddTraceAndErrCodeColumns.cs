using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations.LogError
{
    public partial class AddTraceAndErrCodeColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExceptionCode",
                table: "ErrorLogs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExceptionTrace",
                table: "ErrorLogs",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExceptionCode",
                table: "ErrorLogs");

            migrationBuilder.DropColumn(
                name: "ExceptionTrace",
                table: "ErrorLogs");
        }
    }
}
