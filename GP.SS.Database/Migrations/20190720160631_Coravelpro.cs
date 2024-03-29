﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Oracle.EntityFrameworkCore.Metadata;

namespace GP.SS.Database.Migrations
{
    public partial class Coravelpro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coravel_JobHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    StartedAt = table.Column<DateTime>(nullable: true),
                    EndedAt = table.Column<DateTime>(nullable: true),
                    TypeFullPath = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    Failed = table.Column<bool>(nullable: false),
                    ErrorMessage = table.Column<string>(nullable: true),
                    StackTrace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coravel_JobHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coravel_ScheduledJobHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    EndedAt = table.Column<DateTime>(nullable: true),
                    TypeFullPath = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    Failed = table.Column<bool>(nullable: false),
                    ErrorMessage = table.Column<string>(nullable: true),
                    StackTrace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coravel_ScheduledJobHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coravel_ScheduledJobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    InvocableFullPath = table.Column<string>(nullable: true),
                    CronExpression = table.Column<string>(nullable: true),
                    Frequency = table.Column<string>(nullable: true),
                    Days = table.Column<string>(nullable: true),
                    PreventOverlapping = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coravel_ScheduledJobs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coravel_JobHistory");

            migrationBuilder.DropTable(
                name: "Coravel_ScheduledJobHistory");

            migrationBuilder.DropTable(
                name: "Coravel_ScheduledJobs");
        }
    }
}
