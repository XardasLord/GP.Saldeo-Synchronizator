using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GP.SS.Database.Migrations
{
    public partial class ChangedTimestampToDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_SALE",
                table: "SALDEO_DOCUMENTS",
                type: "DATE",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_RECEIVE",
                table: "SALDEO_DOCUMENTS",
                type: "DATE",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_PAYMENT",
                table: "SALDEO_DOCUMENTS",
                type: "DATE",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_ISSUE",
                table: "SALDEO_DOCUMENTS",
                type: "DATE",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_SALE",
                table: "SALDEO_DOCUMENTS",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DATE",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_RECEIVE",
                table: "SALDEO_DOCUMENTS",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DATE",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_PAYMENT",
                table: "SALDEO_DOCUMENTS",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DATE",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_ISSUE",
                table: "SALDEO_DOCUMENTS",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DATE",
                oldNullable: true);
        }
    }
}
