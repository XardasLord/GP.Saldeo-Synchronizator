using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GP.SS.Database.Migrations
{
    public partial class RenamedColumnsAndChangedTypesAndAddedNewColumnsToSaldeoDocumentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SUM",
                table: "SALDEO_DOCUMENTS",
                newName: "DOCUMENT_KWOTA_BRUTTO");

            migrationBuilder.RenameColumn(
                name: "SALE_DATE",
                table: "SALDEO_DOCUMENTS",
                newName: "DATE_SALE");

            migrationBuilder.RenameColumn(
                name: "RECEIVE_DATE",
                table: "SALDEO_DOCUMENTS",
                newName: "DATE_RECEIVE");

            migrationBuilder.RenameColumn(
                name: "PAYMENT_TYPE",
                table: "SALDEO_DOCUMENTS",
                newName: "DOCUMENT_PAYMENT_TYPE");

            migrationBuilder.RenameColumn(
                name: "PAYMENT_DATE",
                table: "SALDEO_DOCUMENTS",
                newName: "DATE_PAYMENT");

            migrationBuilder.RenameColumn(
                name: "NUMER_DOK",
                table: "SALDEO_DOCUMENTS",
                newName: "DOCUMENT_NUMBER");

            migrationBuilder.RenameColumn(
                name: "ISSUE_DATE",
                table: "SALDEO_DOCUMENTS",
                newName: "DATE_ISSUE");

            migrationBuilder.RenameColumn(
                name: "IS_DOCUMENT_PAID",
                table: "SALDEO_DOCUMENTS",
                newName: "DOCUMENT_IS_PAID");

            migrationBuilder.RenameColumn(
                name: "DESCRIPTION",
                table: "SALDEO_DOCUMENTS",
                newName: "COST_DESCRIPTION");

            migrationBuilder.RenameColumn(
                name: "CATEGORY",
                table: "SALDEO_DOCUMENTS",
                newName: "COST_CATEGORY");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "SALDEO_DOCUMENTS",
                newName: "DOCUMENT_ID");

            migrationBuilder.RenameColumn(
                name: "VAT",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "COST_VAT");

            migrationBuilder.RenameColumn(
                name: "RATE",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "COST_RATE");

            migrationBuilder.RenameColumn(
                name: "NETTO",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "COST_NETTO");

            migrationBuilder.RenameColumn(
                name: "DESCRIPTION",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "COST_DESCRIPTION");

            migrationBuilder.RenameColumn(
                name: "CATEGORY",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "COST_CATEGORY");

            migrationBuilder.RenameColumn(
                name: "VAT_NUMBER",
                table: "SALDEO_COMPANIES",
                newName: "COMPANY_VAT_NUMBER");

            migrationBuilder.RenameColumn(
                name: "USERNAME",
                table: "SALDEO_COMPANIES",
                newName: "COMPANY_USERNAME");

            migrationBuilder.RenameColumn(
                name: "TELEPHONE",
                table: "SALDEO_COMPANIES",
                newName: "COMPANY_TELEPHONE");

            migrationBuilder.RenameColumn(
                name: "STREET",
                table: "SALDEO_COMPANIES",
                newName: "COMPANY_STREET");

            migrationBuilder.RenameColumn(
                name: "SHORT_NAME",
                table: "SALDEO_COMPANIES",
                newName: "COMPANY_SHORT_NAME");

            migrationBuilder.RenameColumn(
                name: "POSTCODE",
                table: "SALDEO_COMPANIES",
                newName: "COMPANY_POSTCODE");

            migrationBuilder.RenameColumn(
                name: "FULL_NAME",
                table: "SALDEO_COMPANIES",
                newName: "COMPANY_FULL_NAME");

            migrationBuilder.RenameColumn(
                name: "EMAIL",
                table: "SALDEO_COMPANIES",
                newName: "COMPANY_EMAIL");

            migrationBuilder.RenameColumn(
                name: "CITY",
                table: "SALDEO_COMPANIES",
                newName: "COMPANY_CITY");

            migrationBuilder.AlterColumn<decimal>(
                name: "DOCUMENT_KWOTA_BRUTTO",
                table: "SALDEO_DOCUMENTS",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_SALE",
                table: "SALDEO_DOCUMENTS",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_RECEIVE",
                table: "SALDEO_DOCUMENTS",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_PAYMENT",
                table: "SALDEO_DOCUMENTS",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_ISSUE",
                table: "SALDEO_DOCUMENTS",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COST_CATEGORY_OPIS",
                table: "SALDEO_DOCUMENTS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COST_CATEGORY_RODZAJ",
                table: "SALDEO_DOCUMENTS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COST_CATEGORY_PODTYP",
                table: "SALDEO_DOCUMENTS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COST_CATEGORY_TYP",
                table: "SALDEO_DOCUMENTS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONTRACTOR_TYP",
                table: "SALDEO_DOCUMENTS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PROJECT_CODE_COPY",
                table: "SALDEO_DOCUMENTS",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "VAT",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NETTO",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "COST_VAT",
                table: "SALDEO_DOCUMENT_ITEMS",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "COST_NETTO",
                table: "SALDEO_DOCUMENT_ITEMS",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "COST_CATEGORY_OPIS",
                table: "SALDEO_DOCUMENTS");

            migrationBuilder.DropColumn(
                name: "COST_CATEGORY_RODZAJ",
                table: "SALDEO_DOCUMENTS");

            migrationBuilder.DropColumn(
                name: "COST_CATEGORY_PODTYP",
                table: "SALDEO_DOCUMENTS");

            migrationBuilder.DropColumn(
                name: "COST_CATEGORY_TYP",
                table: "SALDEO_DOCUMENTS");

            migrationBuilder.DropColumn(
                name: "CONTRACTOR_TYP",
                table: "SALDEO_DOCUMENTS");

            migrationBuilder.DropColumn(
                name: "PROJECT_CODE_COPY",
                table: "SALDEO_DOCUMENTS");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_KWOTA_BRUTTO",
                table: "SALDEO_DOCUMENTS",
                newName: "SUM");

            migrationBuilder.RenameColumn(
                name: "DATE_SALE",
                table: "SALDEO_DOCUMENTS",
                newName: "SALE_DATE");

            migrationBuilder.RenameColumn(
                name: "DATE_RECEIVE",
                table: "SALDEO_DOCUMENTS",
                newName: "RECEIVE_DATE");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_PAYMENT_TYPE",
                table: "SALDEO_DOCUMENTS",
                newName: "PAYMENT_TYPE");

            migrationBuilder.RenameColumn(
                name: "DATE_PAYMENT",
                table: "SALDEO_DOCUMENTS",
                newName: "PAYMENT_DATE");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_NUMBER",
                table: "SALDEO_DOCUMENTS",
                newName: "NUMER_DOK");

            migrationBuilder.RenameColumn(
                name: "DATE_ISSUE",
                table: "SALDEO_DOCUMENTS",
                newName: "ISSUE_DATE");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_IS_PAID",
                table: "SALDEO_DOCUMENTS",
                newName: "IS_DOCUMENT_PAID");

            migrationBuilder.RenameColumn(
                name: "COST_DESCRIPTION",
                table: "SALDEO_DOCUMENTS",
                newName: "DESCRIPTION");

            migrationBuilder.RenameColumn(
                name: "COST_CATEGORY",
                table: "SALDEO_DOCUMENTS",
                newName: "CATEGORY");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT_ID",
                table: "SALDEO_DOCUMENTS",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "COST_VAT",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "VAT");

            migrationBuilder.RenameColumn(
                name: "COST_RATE",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "RATE");

            migrationBuilder.RenameColumn(
                name: "COST_NETTO",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "NETTO");

            migrationBuilder.RenameColumn(
                name: "COST_DESCRIPTION",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "DESCRIPTION");

            migrationBuilder.RenameColumn(
                name: "COST_CATEGORY",
                table: "SALDEO_DOCUMENT_ITEMS",
                newName: "CATEGORY");

            migrationBuilder.RenameColumn(
                name: "COMPANY_VAT_NUMBER",
                table: "SALDEO_COMPANIES",
                newName: "VAT_NUMBER");

            migrationBuilder.RenameColumn(
                name: "COMPANY_USERNAME",
                table: "SALDEO_COMPANIES",
                newName: "USERNAME");

            migrationBuilder.RenameColumn(
                name: "COMPANY_TELEPHONE",
                table: "SALDEO_COMPANIES",
                newName: "TELEPHONE");

            migrationBuilder.RenameColumn(
                name: "COMPANY_STREET",
                table: "SALDEO_COMPANIES",
                newName: "STREET");

            migrationBuilder.RenameColumn(
                name: "COMPANY_SHORT_NAME",
                table: "SALDEO_COMPANIES",
                newName: "SHORT_NAME");

            migrationBuilder.RenameColumn(
                name: "COMPANY_POSTCODE",
                table: "SALDEO_COMPANIES",
                newName: "POSTCODE");

            migrationBuilder.RenameColumn(
                name: "COMPANY_FULL_NAME",
                table: "SALDEO_COMPANIES",
                newName: "FULL_NAME");

            migrationBuilder.RenameColumn(
                name: "COMPANY_EMAIL",
                table: "SALDEO_COMPANIES",
                newName: "EMAIL");

            migrationBuilder.RenameColumn(
                name: "COMPANY_CITY",
                table: "SALDEO_COMPANIES",
                newName: "CITY");

            migrationBuilder.AlterColumn<string>(
                name: "SUM",
                table: "SALDEO_DOCUMENTS",
                nullable: true,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SALE_DATE",
                table: "SALDEO_DOCUMENTS",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RECEIVE_DATE",
                table: "SALDEO_DOCUMENTS",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PAYMENT_DATE",
                table: "SALDEO_DOCUMENTS",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ISSUE_DATE",
                table: "SALDEO_DOCUMENTS",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VAT",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES",
                nullable: true,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NETTO",
                table: "SALDEO_DOCUMENT_VAT_REGISTRIES",
                nullable: true,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VAT",
                table: "SALDEO_DOCUMENT_ITEMS",
                nullable: true,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NETTO",
                table: "SALDEO_DOCUMENT_ITEMS",
                nullable: true,
                oldClrType: typeof(decimal),
                oldNullable: true);
        }
    }
}
