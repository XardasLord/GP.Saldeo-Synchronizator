﻿// <auto-generated />
using System;
using GP.SS.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

namespace GP.SS.Database.Migrations
{
    [DbContext(typeof(SaldeoSynchronizatorContext))]
    [Migration("20190903145333_ChangedTimestampToDate")]
    partial class ChangedTimestampToDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("Coravel.Pro.EntityFramework.CoravelJobHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName");

                    b.Property<DateTime?>("EndedAt");

                    b.Property<string>("ErrorMessage");

                    b.Property<bool>("Failed");

                    b.Property<string>("StackTrace");

                    b.Property<DateTime?>("StartedAt");

                    b.Property<string>("TypeFullPath");

                    b.HasKey("Id");

                    b.ToTable("Coravel_JobHistory");
                });

            modelBuilder.Entity("Coravel.Pro.EntityFramework.CoravelScheduledJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CronExpression");

                    b.Property<string>("Days");

                    b.Property<string>("Frequency");

                    b.Property<string>("InvocableFullPath");

                    b.Property<bool>("PreventOverlapping");

                    b.HasKey("Id");

                    b.ToTable("Coravel_ScheduledJobs");
                });

            modelBuilder.Entity("Coravel.Pro.EntityFramework.CoravelScheduledJobHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName");

                    b.Property<DateTime?>("EndedAt");

                    b.Property<string>("ErrorMessage");

                    b.Property<bool>("Failed");

                    b.Property<string>("StackTrace");

                    b.Property<string>("TypeFullPath");

                    b.HasKey("Id");

                    b.ToTable("Coravel_ScheduledJobHistory");
                });

            modelBuilder.Entity("GP.SS.Domain.Company", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("City")
                        .HasColumnName("COMPANY_CITY");

                    b.Property<string>("CompanyProgramId")
                        .HasColumnName("COMPANY_PROGRAM_ID");

                    b.Property<string>("Email")
                        .HasColumnName("COMPANY_EMAIL");

                    b.Property<string>("FullName")
                        .HasColumnName("COMPANY_FULL_NAME");

                    b.Property<string>("Postcode")
                        .HasColumnName("COMPANY_POSTCODE");

                    b.Property<string>("ShortName")
                        .HasColumnName("COMPANY_SHORT_NAME");

                    b.Property<string>("Street")
                        .HasColumnName("COMPANY_STREET");

                    b.Property<string>("Telephone")
                        .HasColumnName("COMPANY_TELEPHONE");

                    b.Property<string>("Username")
                        .HasColumnName("COMPANY_USERNAME");

                    b.Property<string>("VatNumber")
                        .HasColumnName("COMPANY_VAT_NUMBER");

                    b.HasKey("Id");

                    b.ToTable("SALDEO_COMPANIES");
                });

            modelBuilder.Entity("GP.SS.Domain.Contractor", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("City")
                        .HasColumnName("CITY");

                    b.Property<string>("CompanyId")
                        .HasColumnName("COMPANY_ID");

                    b.Property<string>("CompanyProgramId")
                        .HasColumnName("COMPANY_PROGRAM_ID");

                    b.Property<string>("Emails")
                        .HasColumnName("EMAILS");

                    b.Property<string>("FullName")
                        .HasColumnName("FULL_NAME");

                    b.Property<bool>("IsCustomer")
                        .HasColumnName("IS_CUSTOMER");

                    b.Property<bool>("IsSupplier")
                        .HasColumnName("IS_SUPPLIER");

                    b.Property<string>("Postcode")
                        .HasColumnName("POSTCODE");

                    b.Property<string>("ShortName")
                        .HasColumnName("SHORT_NAME");

                    b.Property<string>("Street")
                        .HasColumnName("STREET");

                    b.Property<string>("Telephone")
                        .HasColumnName("TELEPHONE");

                    b.Property<string>("VatNumber")
                        .HasColumnName("VAT_NUMBER");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("SALDEO_CONTRACTORS");
                });

            modelBuilder.Entity("GP.SS.Domain.Document", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DOCUMENT_ID");

                    b.Property<string>("Category")
                        .HasColumnName("COST_CATEGORY");

                    b.Property<string>("CategoryDescription")
                        .HasColumnName("COST_CATEGORY_OPIS");

                    b.Property<string>("CategoryKind")
                        .HasColumnName("COST_CATEGORY_RODZAJ");

                    b.Property<string>("CategorySubType")
                        .HasColumnName("COST_CATEGORY_PODTYP");

                    b.Property<string>("CategoryType")
                        .HasColumnName("COST_CATEGORY_TYP");

                    b.Property<string>("CompanyId")
                        .HasColumnName("COMPANY_ID");

                    b.Property<string>("ContractorCity")
                        .HasColumnName("CONTRACTOR_CITY");

                    b.Property<string>("ContractorFullName")
                        .HasColumnName("CONTRACTOR_FULL_NAME");

                    b.Property<bool>("ContractorIsCustomer")
                        .HasColumnName("CONTRACTOR_IS_CUSTOMER");

                    b.Property<bool>("ContractorIsSupplier")
                        .HasColumnName("CONTRACTOR_IS_SUPPLIER");

                    b.Property<string>("ContractorPostcode")
                        .HasColumnName("CONTRACTOR_POSTCODE");

                    b.Property<string>("ContractorShortName")
                        .HasColumnName("CONTRACTOR_SHORT_NAME");

                    b.Property<string>("ContractorStreet")
                        .HasColumnName("CONTRACTOR_STREET");

                    b.Property<string>("ContractorTelephone")
                        .HasColumnName("CONTRACTOR_TELEPHONE");

                    b.Property<string>("ContractorType")
                        .HasColumnName("CONTRACTOR_TYP");

                    b.Property<string>("ContractorVatNumber")
                        .HasColumnName("CONTRACTOR_VAT_NUMBER");

                    b.Property<string>("Description")
                        .HasColumnName("COST_DESCRIPTION");

                    b.Property<string>("DocumentTypeName")
                        .HasColumnName("DOCUMENT_TYPE_NAME");

                    b.Property<string>("DocumentTypeShortName")
                        .HasColumnName("DOCUMENT_TYPE_SHORT_NAME");

                    b.Property<bool>("IsDocumentPaid")
                        .HasColumnName("DOCUMENT_IS_PAID");

                    b.Property<DateTime?>("IssueDate")
                        .HasColumnName("DATE_ISSUE")
                        .HasColumnType("DATE");

                    b.Property<string>("Number")
                        .HasColumnName("DOCUMENT_NUMBER");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnName("DATE_PAYMENT")
                        .HasColumnType("DATE");

                    b.Property<string>("PaymentType")
                        .HasColumnName("DOCUMENT_PAYMENT_TYPE");

                    b.Property<string>("ProjectCode")
                        .HasColumnName("PROJECT_CODE");

                    b.Property<string>("ProjectCodeCopy")
                        .HasColumnName("PROJECT_CODE_COPY");

                    b.Property<string>("ProjectName")
                        .HasColumnName("PROJECT_NAME");

                    b.Property<string>("ProjectUser")
                        .HasColumnName("PROJECT_USER");

                    b.Property<DateTime?>("ReceiveDate")
                        .HasColumnName("DATE_RECEIVE")
                        .HasColumnType("DATE");

                    b.Property<DateTime?>("SaleDate")
                        .HasColumnName("DATE_SALE")
                        .HasColumnType("DATE");

                    b.Property<decimal?>("Sum")
                        .HasColumnName("DOCUMENT_KWOTA_BRUTTO");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("SALDEO_DOCUMENTS");
                });

            modelBuilder.Entity("GP.SS.Domain.DocumentItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Category")
                        .HasColumnName("COST_CATEGORY");

                    b.Property<string>("Description")
                        .HasColumnName("COST_DESCRIPTION");

                    b.Property<string>("DocumentId")
                        .HasColumnName("DOCUMENT_ID");

                    b.Property<decimal?>("Netto")
                        .HasColumnName("COST_NETTO");

                    b.Property<string>("Rate")
                        .HasColumnName("COST_RATE");

                    b.Property<decimal?>("Vat")
                        .HasColumnName("COST_VAT");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.ToTable("SALDEO_DOCUMENT_ITEMS");
                });

            modelBuilder.Entity("GP.SS.Domain.DocumentVatRegistry", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("DocumentId")
                        .HasColumnName("DOCUMENT_ID");

                    b.Property<decimal?>("Netto")
                        .HasColumnName("NETTO");

                    b.Property<string>("Rate")
                        .HasColumnName("RATE");

                    b.Property<decimal?>("Vat")
                        .HasColumnName("VAT");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.ToTable("SALDEO_DOCUMENT_VAT_REGISTRIES");
                });

            modelBuilder.Entity("GP.SS.Domain.Contractor", b =>
                {
                    b.HasOne("GP.SS.Domain.Company", "Company")
                        .WithMany("Contractors")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("GP.SS.Domain.Document", b =>
                {
                    b.HasOne("GP.SS.Domain.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("GP.SS.Domain.DocumentItem", b =>
                {
                    b.HasOne("GP.SS.Domain.Document", "Document")
                        .WithMany("DocumentItems")
                        .HasForeignKey("DocumentId");
                });

            modelBuilder.Entity("GP.SS.Domain.DocumentVatRegistry", b =>
                {
                    b.HasOne("GP.SS.Domain.Document", "Document")
                        .WithMany("DocumentVatRegistries")
                        .HasForeignKey("DocumentId");
                });
#pragma warning restore 612, 618
        }
    }
}
