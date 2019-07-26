using Microsoft.EntityFrameworkCore.Migrations;

namespace GP.SS.Database.Migrations
{
    public partial class ModifiedColumnNameAndTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saldeo.Contractors_Saldeo.Companies_CompanyId",
                table: "Saldeo.Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_Saldeo.DocumentItems_Saldeo.Documents_DocumentId",
                table: "Saldeo.DocumentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Saldeo.Documents_Saldeo.Companies_CompanyId",
                table: "Saldeo.Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Saldeo.DocumentVatRegistries_Saldeo.Documents_DocumentId",
                table: "Saldeo.DocumentVatRegistries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo.DocumentVatRegistries",
                table: "Saldeo.DocumentVatRegistries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo.Documents",
                table: "Saldeo.Documents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo.DocumentItems",
                table: "Saldeo.DocumentItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo.Contractors",
                table: "Saldeo.Contractors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo.Companies",
                table: "Saldeo.Companies");

            migrationBuilder.RenameTable(
                name: "Saldeo.DocumentVatRegistries",
                newName: "Saldeo_DocumentVatRegistries");

            migrationBuilder.RenameTable(
                name: "Saldeo.Documents",
                newName: "Saldeo_Documents");

            migrationBuilder.RenameTable(
                name: "Saldeo.DocumentItems",
                newName: "Saldeo_DocumentItems");

            migrationBuilder.RenameTable(
                name: "Saldeo.Contractors",
                newName: "Saldeo_Contractors");

            migrationBuilder.RenameTable(
                name: "Saldeo.Companies",
                newName: "Saldeo_Companies");

            migrationBuilder.RenameIndex(
                name: "IX_Saldeo.DocumentVatRegistries_DocumentId",
                table: "Saldeo_DocumentVatRegistries",
                newName: "IX_Saldeo_DocumentVatRegistries_DocumentId");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Saldeo_Documents",
                newName: "Numer_dok");

            migrationBuilder.RenameIndex(
                name: "IX_Saldeo.Documents_CompanyId",
                table: "Saldeo_Documents",
                newName: "IX_Saldeo_Documents_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Saldeo.DocumentItems_DocumentId",
                table: "Saldeo_DocumentItems",
                newName: "IX_Saldeo_DocumentItems_DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Saldeo.Contractors_CompanyId",
                table: "Saldeo_Contractors",
                newName: "IX_Saldeo_Contractors_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo_DocumentVatRegistries",
                table: "Saldeo_DocumentVatRegistries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo_Documents",
                table: "Saldeo_Documents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo_DocumentItems",
                table: "Saldeo_DocumentItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo_Contractors",
                table: "Saldeo_Contractors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo_Companies",
                table: "Saldeo_Companies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Saldeo_Contractors_Saldeo_Companies_CompanyId",
                table: "Saldeo_Contractors",
                column: "CompanyId",
                principalTable: "Saldeo_Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saldeo_DocumentItems_Saldeo_Documents_DocumentId",
                table: "Saldeo_DocumentItems",
                column: "DocumentId",
                principalTable: "Saldeo_Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saldeo_Documents_Saldeo_Companies_CompanyId",
                table: "Saldeo_Documents",
                column: "CompanyId",
                principalTable: "Saldeo_Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saldeo_DocumentVatRegistries_Saldeo_Documents_DocumentId",
                table: "Saldeo_DocumentVatRegistries",
                column: "DocumentId",
                principalTable: "Saldeo_Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saldeo_Contractors_Saldeo_Companies_CompanyId",
                table: "Saldeo_Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_Saldeo_DocumentItems_Saldeo_Documents_DocumentId",
                table: "Saldeo_DocumentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Saldeo_Documents_Saldeo_Companies_CompanyId",
                table: "Saldeo_Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Saldeo_DocumentVatRegistries_Saldeo_Documents_DocumentId",
                table: "Saldeo_DocumentVatRegistries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo_DocumentVatRegistries",
                table: "Saldeo_DocumentVatRegistries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo_Documents",
                table: "Saldeo_Documents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo_DocumentItems",
                table: "Saldeo_DocumentItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo_Contractors",
                table: "Saldeo_Contractors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo_Companies",
                table: "Saldeo_Companies");

            migrationBuilder.RenameTable(
                name: "Saldeo_DocumentVatRegistries",
                newName: "Saldeo.DocumentVatRegistries");

            migrationBuilder.RenameTable(
                name: "Saldeo_Documents",
                newName: "Saldeo.Documents");

            migrationBuilder.RenameTable(
                name: "Saldeo_DocumentItems",
                newName: "Saldeo.DocumentItems");

            migrationBuilder.RenameTable(
                name: "Saldeo_Contractors",
                newName: "Saldeo.Contractors");

            migrationBuilder.RenameTable(
                name: "Saldeo_Companies",
                newName: "Saldeo.Companies");

            migrationBuilder.RenameIndex(
                name: "IX_Saldeo_DocumentVatRegistries_DocumentId",
                table: "Saldeo.DocumentVatRegistries",
                newName: "IX_Saldeo.DocumentVatRegistries_DocumentId");

            migrationBuilder.RenameColumn(
                name: "Numer_dok",
                table: "Saldeo.Documents",
                newName: "Number");

            migrationBuilder.RenameIndex(
                name: "IX_Saldeo_Documents_CompanyId",
                table: "Saldeo.Documents",
                newName: "IX_Saldeo.Documents_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Saldeo_DocumentItems_DocumentId",
                table: "Saldeo.DocumentItems",
                newName: "IX_Saldeo.DocumentItems_DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Saldeo_Contractors_CompanyId",
                table: "Saldeo.Contractors",
                newName: "IX_Saldeo.Contractors_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo.DocumentVatRegistries",
                table: "Saldeo.DocumentVatRegistries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo.Documents",
                table: "Saldeo.Documents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo.DocumentItems",
                table: "Saldeo.DocumentItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo.Contractors",
                table: "Saldeo.Contractors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo.Companies",
                table: "Saldeo.Companies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Saldeo.Contractors_Saldeo.Companies_CompanyId",
                table: "Saldeo.Contractors",
                column: "CompanyId",
                principalTable: "Saldeo.Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saldeo.DocumentItems_Saldeo.Documents_DocumentId",
                table: "Saldeo.DocumentItems",
                column: "DocumentId",
                principalTable: "Saldeo.Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saldeo.Documents_Saldeo.Companies_CompanyId",
                table: "Saldeo.Documents",
                column: "CompanyId",
                principalTable: "Saldeo.Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saldeo.DocumentVatRegistries_Saldeo.Documents_DocumentId",
                table: "Saldeo.DocumentVatRegistries",
                column: "DocumentId",
                principalTable: "Saldeo.Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
