using Microsoft.EntityFrameworkCore.Migrations;

namespace GP.SS.Database.Migrations
{
    public partial class CreateCompanyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Saldeo.Companies",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CompanyProgramId = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    VatNumber = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saldeo.Companies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Saldeo.Companies");
        }
    }
}
