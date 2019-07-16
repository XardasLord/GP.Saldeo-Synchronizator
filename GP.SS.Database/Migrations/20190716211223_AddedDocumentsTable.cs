using Microsoft.EntityFrameworkCore.Migrations;
using Oracle.EntityFrameworkCore.Metadata;

namespace GP.SS.Database.Migrations
{
    public partial class AddedDocumentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Saldeo.Documents",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    DocumentTypeName = table.Column<string>(nullable: true),
                    DocumentTypeShortName = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IssueDate = table.Column<string>(nullable: true),
                    SaleDate = table.Column<string>(nullable: true),
                    PaymentDate = table.Column<string>(nullable: true),
                    ReceiveDate = table.Column<string>(nullable: true),
                    IsDocumentPaid = table.Column<bool>(nullable: false),
                    PaymentType = table.Column<string>(nullable: true),
                    Sum = table.Column<string>(nullable: true),
                    ContractorShortName = table.Column<string>(nullable: true),
                    ContractorFullName = table.Column<string>(nullable: true),
                    ContractorIsSupplier = table.Column<bool>(nullable: false),
                    ContractorIsCustomer = table.Column<bool>(nullable: false),
                    ContractorVatNumber = table.Column<string>(nullable: true),
                    ContractorCity = table.Column<string>(nullable: true),
                    ContractorPostcode = table.Column<string>(nullable: true),
                    ContractorStreet = table.Column<string>(nullable: true),
                    ContractorTelephone = table.Column<string>(nullable: true),
                    CompanyId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saldeo.Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Saldeo.Documents_Saldeo.Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Saldeo.Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Saldeo.DocumentItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    Rate = table.Column<string>(nullable: true),
                    Netto = table.Column<string>(nullable: true),
                    Vat = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DocumentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saldeo.DocumentItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Saldeo.DocumentItems_Saldeo.Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Saldeo.Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Saldeo.DocumentVatRegistries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    Rate = table.Column<string>(nullable: true),
                    Netto = table.Column<string>(nullable: true),
                    Vat = table.Column<string>(nullable: true),
                    DocumentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saldeo.DocumentVatRegistries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Saldeo.DocumentVatRegistries_Saldeo.Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Saldeo.Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Saldeo.DocumentItems_DocumentId",
                table: "Saldeo.DocumentItems",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Saldeo.Documents_CompanyId",
                table: "Saldeo.Documents",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Saldeo.DocumentVatRegistries_DocumentId",
                table: "Saldeo.DocumentVatRegistries",
                column: "DocumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Saldeo.DocumentItems");

            migrationBuilder.DropTable(
                name: "Saldeo.DocumentVatRegistries");

            migrationBuilder.DropTable(
                name: "Saldeo.Documents");
        }
    }
}
