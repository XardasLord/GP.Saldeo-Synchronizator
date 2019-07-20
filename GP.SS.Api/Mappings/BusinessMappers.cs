using System.Linq;
using AutoMapper;

namespace GP.SS.Api.Mappings
{
    public class BusinessMappers : Profile
    {
        public BusinessMappers()
        {
            CreateMap<Infrastructure.SaldeoSmart.ResponseModels.Company, Domain.Company>();

            CreateMap<Infrastructure.SaldeoSmart.ResponseModels.Contractor, Domain.Contractor>()
                .ForMember(x => x.Emails, opt => opt.MapFrom(y => string.Join(';', y.Emails.Select(e => e.Email))));

            CreateMap<Infrastructure.SaldeoSmart.ResponseModels.Document, Domain.Document>()
                .ForMember(x => x.ContractorFullName, opt => opt.Ignore())
                .ForMember(x => x.ContractorShortName, opt => opt.Ignore())
                .ForMember(x => x.ContractorVatNumber, opt => opt.Ignore())
                .ForMember(x => x.ContractorCity, opt => opt.Ignore())
                .ForMember(x => x.ContractorStreet, opt => opt.Ignore())
                .ForMember(x => x.ContractorPostcode, opt => opt.Ignore())
                .ForMember(x => x.ContractorTelephone, opt => opt.Ignore())
                .ForMember(x => x.ContractorIsCustomer, opt => opt.Ignore())
                .ForMember(x => x.ContractorIsSupplier, opt => opt.Ignore())
                .ForMember(x => x.Id, opt => opt.MapFrom(y => y.DocumentId))
                .ForMember(x => x.DocumentVatRegistries, opt => opt.MapFrom(y => y.VatRegistries.VatRegistryList))
                .ForMember(x => x.DocumentItems, opt => opt.MapFrom(y => y.Items.ItemsList));

            CreateMap<Infrastructure.SaldeoSmart.ResponseModels.VatRegistry, Domain.DocumentVatRegistry>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.DocumentId, opt => opt.Ignore());

            CreateMap<Infrastructure.SaldeoSmart.ResponseModels.Item, Domain.DocumentItem>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.DocumentId, opt => opt.Ignore());
        }
    }
}