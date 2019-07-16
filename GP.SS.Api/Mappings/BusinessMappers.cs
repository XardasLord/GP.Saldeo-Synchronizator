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
                .ForMember(x => x.Emails, opt => opt.MapFrom(y => string.Join(';', y.Emails.ToList())));
        }
    }
}