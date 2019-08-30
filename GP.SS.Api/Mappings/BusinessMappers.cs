using System;
using System.Globalization;
using System.Linq;
using AutoMapper;
using GP.SS.Domain;
using GP.SS.Infrastructure.SaldeoSmart.ResponseModels;
using Company = GP.SS.Infrastructure.SaldeoSmart.ResponseModels.Company;
using Contractor = GP.SS.Infrastructure.SaldeoSmart.ResponseModels.Contractor;
using Document = GP.SS.Infrastructure.SaldeoSmart.ResponseModels.Document;
using DocumentItem = GP.SS.Domain.DocumentItem;

namespace GP.SS.Api.Mappings
{
    public class BusinessMappers : Profile
    {
        public BusinessMappers()
        {
            CreateMap<Company, Domain.Company>();

            CreateMap<Contractor, Domain.Contractor>()
                .ForMember(x => x.Id, opt => opt.MapFrom(y => y.ContractorId))
                .ForMember(x => x.Emails, opt => opt.MapFrom(y => string.Join(';', y.Emails.Select(e => e.Email))));

            CreateMap<Document, Domain.Document>()
                .ForMember(x => x.Id, opt => opt.MapFrom(y => y.DocumentId))
                .ForMember(x => x.IssueDate, opt => opt.MapFrom(y => 
                    string.IsNullOrEmpty(y.IssueDate) ? 
                        (DateTime?)null :
                        DateTime.ParseExact(y.IssueDate, "yyyy-MM-dd", CultureInfo.InvariantCulture)))
                .ForMember(x => x.SaleDate, opt => opt.MapFrom(y =>
                    string.IsNullOrEmpty(y.SaleDate) ?
                        (DateTime?)null :
                        DateTime.ParseExact(y.SaleDate, "yyyy-MM-dd", CultureInfo.InvariantCulture)))
                .ForMember(x => x.ReceiveDate, opt => opt.MapFrom(y =>
                    string.IsNullOrEmpty(y.ReceiveDate) ?
                        (DateTime?)null :
                        DateTime.ParseExact(y.ReceiveDate, "yyyy-MM-dd", CultureInfo.InvariantCulture)))
                .ForMember(x => x.PaymentDate, opt => opt.MapFrom(y =>
                    string.IsNullOrEmpty(y.PaymentDate) ?
                        (DateTime?)null :
                        DateTime.ParseExact(y.PaymentDate, "yyyy-MM-dd", CultureInfo.InvariantCulture)))
                .ForMember(x => x.Sum, opt => opt.MapFrom(y => 
                    string.IsNullOrEmpty(y.Sum) ? 
                        (decimal?)null :
                        decimal.Parse(y.Sum, CultureInfo.InvariantCulture)))
                .ForMember(x => x.ContractorFullName, opt => opt.Ignore())
                .ForMember(x => x.ContractorShortName, opt => opt.Ignore())
                .ForMember(x => x.ContractorVatNumber, opt => opt.Ignore())
                .ForMember(x => x.ContractorCity, opt => opt.Ignore())
                .ForMember(x => x.ContractorStreet, opt => opt.Ignore())
                .ForMember(x => x.ContractorPostcode, opt => opt.Ignore())
                .ForMember(x => x.ContractorTelephone, opt => opt.Ignore())
                .ForMember(x => x.ContractorIsCustomer, opt => opt.Ignore())
                .ForMember(x => x.ContractorIsSupplier, opt => opt.Ignore())
                .ForMember(x => x.ContractorType, opt => opt.Ignore())
                .ForMember(x => x.ProjectUser, opt => opt.Ignore())
                .ForMember(x => x.ProjectCode, opt => opt.Ignore())
                .ForMember(x => x.ProjectCodeCopy, opt => opt.Ignore())
                .ForMember(x => x.ProjectName, opt => opt.Ignore())
                .ForMember(x => x.CategoryDescription, opt => opt.Ignore())
                .ForMember(x => x.CategoryKind, opt => opt.Ignore())
                .ForMember(x => x.CategoryType, opt => opt.Ignore())
                .ForMember(x => x.CategorySubType, opt => opt.Ignore())
                .ForMember(x => x.DocumentVatRegistries, opt => opt.MapFrom(y => y.VatRegistries.VatRegistryList))
                .ForMember(x => x.DocumentItems, opt => opt.MapFrom(y => y.Items.ItemsList));

            CreateMap<VatRegistry, DocumentVatRegistry>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.DocumentId, opt => opt.Ignore())
                .ForMember(x => x.Netto, opt => opt.Ignore())
                .ForMember(x => x.Vat, opt => opt.Ignore())
                .ForMember(x => x.Netto, opt => opt.MapFrom(y =>
                    string.IsNullOrEmpty(y.Netto)
                        ? (decimal?) null
                        : decimal.Parse(y.Netto, CultureInfo.InvariantCulture)))
                .ForMember(x => x.Vat, opt => opt.MapFrom(y =>
                    string.IsNullOrEmpty(y.Vat)
                        ? (decimal?) null
                        : decimal.Parse(y.Vat, CultureInfo.InvariantCulture)));

            CreateMap<Item, DocumentItem>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.DocumentId, opt => opt.Ignore())
                .ForMember(x => x.Netto, opt => opt.Ignore())
                .ForMember(x => x.Vat, opt => opt.Ignore())
                .ForMember(x => x.Netto, opt => opt.MapFrom(y =>
                    string.IsNullOrEmpty(y.Netto)
                        ? (decimal?) null
                        : decimal.Parse(y.Netto, CultureInfo.InvariantCulture)))
                .ForMember(x => x.Vat, opt => opt.MapFrom(y =>
                    string.IsNullOrEmpty(y.Vat)
                        ? (decimal?) null
                        : decimal.Parse(y.Vat, CultureInfo.InvariantCulture)));
        }
    }
}