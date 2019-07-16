using Microsoft.EntityFrameworkCore.Migrations;

namespace GP.SS.Database.Migrations
{
    public partial class CreateContratorsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Saldeo.Contractors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ContractorProgramId = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    IsSupplier = table.Column<bool>(nullable: false),
                    IsCustomer = table.Column<bool>(nullable: false),
                    VatNumber = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Emails = table.Column<string>(nullable: true),
                    CompanyId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saldeo.Contractors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Saldeo.Contractors_Saldeo.Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Saldeo.Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Saldeo.Contractors_CompanyId",
                table: "Saldeo.Contractors",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Saldeo.Contractors");
        }
    }
}
