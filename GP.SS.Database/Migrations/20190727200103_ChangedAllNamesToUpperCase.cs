using Microsoft.EntityFrameworkCore.Migrations;

namespace GP.SS.Database.Migrations
{
    public partial class ChangedAllNamesToUpperCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PK_Saldeo_Documents",
                table: "Saldeo_Documents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo_Contractors",
                table: "Saldeo_Contractors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo_Companies",
                table: "Saldeo_Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo_DocumentVatRegistries",
                table: "Saldeo_DocumentVatRegistries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saldeo_DocumentItems",
                table: "Saldeo_DocumentItems");

            migrationBuilder.RenameTable(
                name: "Saldeo_Documents",
                newName: "SALDEO_DOCUMENTS");

            migrationBuilder.RenameTable(
                name: "Saldeo_Contractors",
                newName: "SALDEO_CONTRACTORS");

            migrationBuilder.RenameTable(
                name: "Saldeo_Companies",
                newName: "SALDEO_COMPANIES");

            migrationBuilder.RenameTable(
                name: "Saldeo_DocumentVatRegistries",
                newName: "SALDEO_DOCUMENT_VAT_REGISTRIES");

            migrationBuilder.RenameTable(
                name: "Saldeo_DocumentItems",
                newName: "SALDEO_DOCUMENT_ITEMS");

            migrationBuilder.RenameColumn(
                name: "Sum",
                table: "SALDEO_DOCUMENTS",
                newName: "SUM");

            migrationBuilder.RenameColumn(
                name: "Project",
                table: "SALDEO_DOCUMENTS",
                newName: "PROJECT");

            migrationBuilder.RenameColumn(
                name: "Numer_dok",
                table: "SALDEO_DOCUMENTS",
                newName: "NUMER_DOK");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "SALDEO_DOCUMENTS",
                newName: "DESCRIPTION");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "SALDEO_DOCUMENTS",
                newName: "CATEGORY");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SALDEO_DOCUMENTS",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "SaleDate",
                table: "SALDEO_DOCUMENTS",
                newName: "SALE_DATE");

            migrationBuilder.RenameColumn(
                name: "ReceiveDate",
                table: "SALDEO_DOCUMENTS",
                newName: "RECEIVE_DATE");

            migrationBuilder.RenameColumn(
                name: "PaymentType",
                table: "SALDEO_DOCUMENTS",
                newName: "PAYMENT_TYPE");

            migrationBuilder.RenameColumn(
                name: "PaymentDate",
                table: "SALDEO_DOCUMENTS",
                newName: "PAYMENT_DATE");

            migrationBuilder.RenameColumn(
                name: "IssueDate",
                table: "SALDEO_DOCUMENTS",
                newName: "ISSUE_DATE");

            migrationBuilder.RenameColumn(
                name: "IsDocumentPaid",
                table: "SALDEO_DOCUMENTS",
                newName: "IS_DOCUMENT_PAID");

            migrationBuilder.RenameColumn(
                name: "DocumentTypeShortName",
                table: "SALDEO_DOCUMENTS",
                newName: "DOCUMENT_TYPE_SHORT_NAME");

            migrationBuilder.RenameColumn(
                name: "DocumentTypeName",
                table: "SALDEO_DOCUMENTS",
                newName: "DOCUMENT_TYPE_NAME");

            migrationBuilder.RenameColumn(
                name: "ContractorVatNumber",
                table: "SALDEO_DOCUMENTS",
                newName: "CONTRACTOR_VAT_NUMBER");

            migrationBuilder.RenameColumn(
                name: "ContractorTelephone",
                table: "SALDEO_DOCUMENTS",
                newName: "CONTRACTOR_TELEPHONE");

            migrationBuilder.RenameColumn(
                name: "ContractorStreet",
                table: "SALDEO_DOCUMENTS",
                newName: "CONTRACTOR_STREET");

            migrationBuilder.RenameColumn(
                name: "ContractorShortName",
                table: "SALDEO_DOCUMENTS",
                newName: "CONTRACTOR_SHORT_NAME");

            migrationBuilder.RenameColumn(
                name: "ContractorPostcode",
                table: "SALDEO_DOCUMENTS",
                newName: "CONTRACTOR_POSTCODE");

            migrationBuilder.RenameColumn(
                name: "ContractorIsSupplier",
                table: "SALDEO_DOCUMENTS",
                newName: "CONTRACTOR_IS_SUPPLIER");

            migrationBuilder.RenameColumn(
                name: "ContractorIsCustomer",
                table: "SALDEO_DOCUMENTS",
                newName: "CONTRACTOR_IS_CUSTOMER");

            migrationBuilder.RenameColumn(
                name: "ContractorFullName",
                table: "SALDEO_DOCUMENTS",
                newName: "CONTRACTOR_FULL_NAME");

            migrationBuilder.RenameColumn(
                name: "ContractorCity",
                table: "SALDEO_DOCUMENTS",
                newName: "CONTRACTOR_CITY");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "SALDEO_DOCUMENTS",
                newName: "COMPANY_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Saldeo_Documents_CompanyId",
                table: "SALDEO_DOCUMENTS",
                newName: "IX_SALDEO_DOCUMENTS_COMPANY_ID");

            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "SALDEO_CONTRACTORS",
                newName: "TELEPHONE");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "SALDEO_CONTRACTORS",
                newName: "STREET");

            migrationBuilder.RenameColumn(
                name: "Postcode",
                table: "SALDEO_CONTRACTORS",
                newName: "POSTCODE");

            migrationBuilder.RenameColumn(
                name: "Emails",
                table: "SALDEO_CONTRACTORS",
                newName: "EMAILS");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "SALDEO_CONTRACTORS",
                newName: "CITY");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SALDEO_CONTRACTORS",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "VatNumber",
                table: "SALDEO_CONTRACTORS",
                newName: "VAT_NUMBER");

            migrationBuilder.RenameColumn(
                name: "ShortName",
                table: "SALDEO_CONTRACTORS",
                newName: "SHORT_NAME");

            migrationBuilder.RenameColumn(
                name: "IsSupplier",
                table: "SALDEO_CONTRACTORS",
                newName: "IS_SUPPLIER");

            migrationBuilder.RenameColumn(
                name: "IsCustomer",
                table: "SALDEO_CONTRACTORS",
                newName: "IS_CUSTOMER");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "SALDEO_CONTRACTORS",
                newName: "FULL_NAME");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "SALDEO_CONTRACTORS",
                newName: "COMPANY_ID");

            migrationBuilder.RenameColumn(
                name: "ContractorProgramId",
                table: "SALDEO_CONTRACTORS",
                newName: "COMPANY_PROGRAM_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Saldeo_Contractors_CompanyId",
                table: "SALDEO_CONTRACTORS",
                newName: "IX_SALDEO_CONTRACTORS_COMPANY_ID");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "SALDEO_COMPANIES",
                newName: "USERNAME");

            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "SALDEO_COMPANIES",
                newName: "TELEPHONE");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "SALDEO_COMPANIES",
                newName: "STREET");

            migrationBuilder.RenameColumn(
                name: "Postcode",
                table: "SALDEO_COMPANIES",
                newName: "POSTCODE");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "SALDEO_COMPANIES",
                newName: "EMAIL");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "SALDEO_COMPANIES",
                newName: "CITY");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SALDEO_COMPANIES",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "VatNumber",
                table: "SALDEO_COMPANIES",
                newName: "VAT_NUMBER");

            migrationBuilder.RenameColumn(
                name: "ShortName",
                table: "SALDEO_COMPANIES",
                newName: "SHORT_NAME");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "SALDEO_COMPANIES",
                newName: "FULL_NAME");

            migrationBuilder.RenameColumn(
                name: "CompanyProgramId",
                table: "SALDEO_COMPANIES",
                newName: "COMPANY_PROGRAM_ID");

            migrationBuilder.RenameColumn(
                name: "Vat",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES",
                newName: "VAT");

            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES",
                newName: "RATE");

            migrationBuilder.RenameColumn(
                name: "Netto",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES",
                newName: "NETTO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "DocumentId",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES",
                newName: "DOCUMENT_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Saldeo_DocumentVatRegistries_DocumentId",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES",
                newName: "IX_SALDEO_DOCUMENT_VAT_REGISTRIES_DOCUMENT_ID");

            migrationBuilder.RenameColumn(
                name: "Vat",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "VAT");

            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "RATE");

            migrationBuilder.RenameColumn(
                name: "Netto",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "NETTO");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "DESCRIPTION");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "CATEGORY");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "DocumentId",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "DOCUMENT_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Saldeo_DocumentItems_DocumentId",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "IX_SALDEO_DOCUMENT_ITEMS_DOCUMENT_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SALDEO_DOCUMENTS",
                table: "SALDEO_DOCUMENTS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SALDEO_CONTRACTORS",
                table: "SALDEO_CONTRACTORS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SALDEO_COMPANIES",
                table: "SALDEO_COMPANIES",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SALDEO_DOCUMENT_VAT_REGISTRIES",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SALDEO_DOCUMENT_ITEMS",
                table: "SALDEO_DOCUMENT_ITEMS",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SALDEO_CONTRACTORS_SALDEO_COMPANIES_COMPANY_ID",
                table: "SALDEO_CONTRACTORS",
                column: "COMPANY_ID",
                principalTable: "SALDEO_COMPANIES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SALDEO_DOCUMENT_ITEMS_SALDEO_DOCUMENTS_DOCUMENT_ID",
                table: "SALDEO_DOCUMENT_ITEMS",
                column: "DOCUMENT_ID",
                principalTable: "SALDEO_DOCUMENTS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SALDEO_DOCUMENT_VAT_REGISTRIES_SALDEO_DOCUMENTS_DOCUMENT_ID",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES",
                column: "DOCUMENT_ID",
                principalTable: "SALDEO_DOCUMENTS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SALDEO_DOCUMENTS_SALDEO_COMPANIES_COMPANY_ID",
                table: "SALDEO_DOCUMENTS",
                column: "COMPANY_ID",
                principalTable: "SALDEO_COMPANIES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SALDEO_CONTRACTORS_SALDEO_COMPANIES_COMPANY_ID",
                table: "SALDEO_CONTRACTORS");

            migrationBuilder.DropForeignKey(
                name: "FK_SALDEO_DOCUMENT_ITEMS_SALDEO_DOCUMENTS_DOCUMENT_ID",
                table: "SALDEO_DOCUMENT_ITEMS");

            migrationBuilder.DropForeignKey(
                name: "FK_SALDEO_DOCUMENT_VAT_REGISTRIES_SALDEO_DOCUMENTS_DOCUMENT_ID",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES");

            migrationBuilder.DropForeignKey(
                name: "FK_SALDEO_DOCUMENTS_SALDEO_COMPANIES_COMPANY_ID",
                table: "SALDEO_DOCUMENTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SALDEO_DOCUMENTS",
                table: "SALDEO_DOCUMENTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SALDEO_CONTRACTORS",
                table: "SALDEO_CONTRACTORS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SALDEO_COMPANIES",
                table: "SALDEO_COMPANIES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SALDEO_DOCUMENT_VAT_REGISTRIES",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SALDEO_DOCUMENT_ITEMS",
                table: "SALDEO_DOCUMENT_ITEMS");

            migrationBuilder.RenameTable(
                name: "SALDEO_DOCUMENTS",
                newName: "Saldeo_Documents");

            migrationBuilder.RenameTable(
                name: "SALDEO_CONTRACTORS",
                newName: "Saldeo_Contractors");

            migrationBuilder.RenameTable(
                name: "SALDEO_COMPANIES",
                newName: "Saldeo_Companies");

            migrationBuilder.RenameTable(
                name: "SALDEO_DOCUMENT_VAT_REGISTRIES",
                newName: "Saldeo_DocumentVatRegistries");

            migrationBuilder.RenameTable(
                name: "SALDEO_DOCUMENT_ITEMS",
                newName: "Saldeo_DocumentItems");

            migrationBuilder.RenameColumn(
                name: "SUM",
                table: "Saldeo_Documents",
                newName: "Sum");

            migrationBuilder.RenameColumn(
                name: "PROJECT",
                table: "Saldeo_Documents",
                newName: "Project");

            migrationBuilder.RenameColumn(
                name: "NUMER_DOK",
                table: "Saldeo_Documents",
                newName: "Numer_dok");

            migrationBuilder.RenameColumn(
                name: "DESCRIPTION",
                table: "Saldeo_Documents",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CATEGORY",
                table: "Saldeo_Documents",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Saldeo_Documents",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SALE_DATE",
                table: "Saldeo_Documents",
                newName: "SaleDate");

            migrationBuilder.RenameColumn(
                name: "RECEIVE_DATE",
                table: "Saldeo_Documents",
                newName: "ReceiveDate");

            migrationBuilder.RenameColumn(
                name: "PAYMENT_TYPE",
                table: "Saldeo_Documents",
                newName: "PaymentType");

            migrationBuilder.RenameColumn(
                name: "PAYMENT_DATE",
                table: "Saldeo_Documents",
                newName: "PaymentDate");

            migrationBuilder.RenameColumn(
                name: "ISSUE_DATE",
                table: "Saldeo_Documents",
                newName: "IssueDate");

            migrationBuilder.RenameColumn(
                name: "IS_DOCUMENT_PAID",
                table: "Saldeo_Documents",
                newName: "IsDocumentPaid");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_TYPE_SHORT_NAME",
                table: "Saldeo_Documents",
                newName: "DocumentTypeShortName");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_TYPE_NAME",
                table: "Saldeo_Documents",
                newName: "DocumentTypeName");

            migrationBuilder.RenameColumn(
                name: "CONTRACTOR_VAT_NUMBER",
                table: "Saldeo_Documents",
                newName: "ContractorVatNumber");

            migrationBuilder.RenameColumn(
                name: "CONTRACTOR_TELEPHONE",
                table: "Saldeo_Documents",
                newName: "ContractorTelephone");

            migrationBuilder.RenameColumn(
                name: "CONTRACTOR_STREET",
                table: "Saldeo_Documents",
                newName: "ContractorStreet");

            migrationBuilder.RenameColumn(
                name: "CONTRACTOR_SHORT_NAME",
                table: "Saldeo_Documents",
                newName: "ContractorShortName");

            migrationBuilder.RenameColumn(
                name: "CONTRACTOR_POSTCODE",
                table: "Saldeo_Documents",
                newName: "ContractorPostcode");

            migrationBuilder.RenameColumn(
                name: "CONTRACTOR_IS_SUPPLIER",
                table: "Saldeo_Documents",
                newName: "ContractorIsSupplier");

            migrationBuilder.RenameColumn(
                name: "CONTRACTOR_IS_CUSTOMER",
                table: "Saldeo_Documents",
                newName: "ContractorIsCustomer");

            migrationBuilder.RenameColumn(
                name: "CONTRACTOR_FULL_NAME",
                table: "Saldeo_Documents",
                newName: "ContractorFullName");

            migrationBuilder.RenameColumn(
                name: "CONTRACTOR_CITY",
                table: "Saldeo_Documents",
                newName: "ContractorCity");

            migrationBuilder.RenameColumn(
                name: "COMPANY_ID",
                table: "Saldeo_Documents",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_SALDEO_DOCUMENTS_COMPANY_ID",
                table: "Saldeo_Documents",
                newName: "IX_Saldeo_Documents_CompanyId");

            migrationBuilder.RenameColumn(
                name: "TELEPHONE",
                table: "Saldeo_Contractors",
                newName: "Telephone");

            migrationBuilder.RenameColumn(
                name: "STREET",
                table: "Saldeo_Contractors",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "POSTCODE",
                table: "Saldeo_Contractors",
                newName: "Postcode");

            migrationBuilder.RenameColumn(
                name: "EMAILS",
                table: "Saldeo_Contractors",
                newName: "Emails");

            migrationBuilder.RenameColumn(
                name: "CITY",
                table: "Saldeo_Contractors",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Saldeo_Contractors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VAT_NUMBER",
                table: "Saldeo_Contractors",
                newName: "VatNumber");

            migrationBuilder.RenameColumn(
                name: "SHORT_NAME",
                table: "Saldeo_Contractors",
                newName: "ShortName");

            migrationBuilder.RenameColumn(
                name: "IS_SUPPLIER",
                table: "Saldeo_Contractors",
                newName: "IsSupplier");

            migrationBuilder.RenameColumn(
                name: "IS_CUSTOMER",
                table: "Saldeo_Contractors",
                newName: "IsCustomer");

            migrationBuilder.RenameColumn(
                name: "FULL_NAME",
                table: "Saldeo_Contractors",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "COMPANY_ID",
                table: "Saldeo_Contractors",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "COMPANY_PROGRAM_ID",
                table: "Saldeo_Contractors",
                newName: "ContractorProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_SALDEO_CONTRACTORS_COMPANY_ID",
                table: "Saldeo_Contractors",
                newName: "IX_Saldeo_Contractors_CompanyId");

            migrationBuilder.RenameColumn(
                name: "USERNAME",
                table: "Saldeo_Companies",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "TELEPHONE",
                table: "Saldeo_Companies",
                newName: "Telephone");

            migrationBuilder.RenameColumn(
                name: "STREET",
                table: "Saldeo_Companies",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "POSTCODE",
                table: "Saldeo_Companies",
                newName: "Postcode");

            migrationBuilder.RenameColumn(
                name: "EMAIL",
                table: "Saldeo_Companies",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "CITY",
                table: "Saldeo_Companies",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Saldeo_Companies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VAT_NUMBER",
                table: "Saldeo_Companies",
                newName: "VatNumber");

            migrationBuilder.RenameColumn(
                name: "SHORT_NAME",
                table: "Saldeo_Companies",
                newName: "ShortName");

            migrationBuilder.RenameColumn(
                name: "FULL_NAME",
                table: "Saldeo_Companies",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "COMPANY_PROGRAM_ID",
                table: "Saldeo_Companies",
                newName: "CompanyProgramId");

            migrationBuilder.RenameColumn(
                name: "VAT",
                table: "Saldeo_DocumentVatRegistries",
                newName: "Vat");

            migrationBuilder.RenameColumn(
                name: "RATE",
                table: "Saldeo_DocumentVatRegistries",
                newName: "Rate");

            migrationBuilder.RenameColumn(
                name: "NETTO",
                table: "Saldeo_DocumentVatRegistries",
                newName: "Netto");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Saldeo_DocumentVatRegistries",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_ID",
                table: "Saldeo_DocumentVatRegistries",
                newName: "DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_SALDEO_DOCUMENT_VAT_REGISTRIES_DOCUMENT_ID",
                table: "Saldeo_DocumentVatRegistries",
                newName: "IX_Saldeo_DocumentVatRegistries_DocumentId");

            migrationBuilder.RenameColumn(
                name: "VAT",
                table: "Saldeo_DocumentItems",
                newName: "Vat");

            migrationBuilder.RenameColumn(
                name: "RATE",
                table: "Saldeo_DocumentItems",
                newName: "Rate");

            migrationBuilder.RenameColumn(
                name: "NETTO",
                table: "Saldeo_DocumentItems",
                newName: "Netto");

            migrationBuilder.RenameColumn(
                name: "DESCRIPTION",
                table: "Saldeo_DocumentItems",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CATEGORY",
                table: "Saldeo_DocumentItems",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Saldeo_DocumentItems",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_ID",
                table: "Saldeo_DocumentItems",
                newName: "DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_SALDEO_DOCUMENT_ITEMS_DOCUMENT_ID",
                table: "Saldeo_DocumentItems",
                newName: "IX_Saldeo_DocumentItems_DocumentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo_Documents",
                table: "Saldeo_Documents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo_Contractors",
                table: "Saldeo_Contractors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo_Companies",
                table: "Saldeo_Companies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo_DocumentVatRegistries",
                table: "Saldeo_DocumentVatRegistries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saldeo_DocumentItems",
                table: "Saldeo_DocumentItems",
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
    }
}
