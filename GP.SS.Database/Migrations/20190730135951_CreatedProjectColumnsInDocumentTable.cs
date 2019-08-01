using Microsoft.EntityFrameworkCore.Migrations;

namespace GP.SS.Database.Migrations
{
    public partial class CreatedProjectColumnsInDocumentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PROJECT",
                table: "SALDEO_DOCUMENTS",
                newName: "PROJECT_USER");

            migrationBuilder.AddColumn<string>(
                name: "PROJECT_CODE",
                table: "SALDEO_DOCUMENTS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PROJECT_NAME",
                table: "SALDEO_DOCUMENTS",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PROJECT_CODE",
                table: "SALDEO_DOCUMENTS");

            migrationBuilder.DropColumn(
                name: "PROJECT_NAME",
                table: "SALDEO_DOCUMENTS");

            migrationBuilder.RenameColumn(
                name: "PROJECT_USER",
                table: "SALDEO_DOCUMENTS",
                newName: "PROJECT");
        }
    }
}
