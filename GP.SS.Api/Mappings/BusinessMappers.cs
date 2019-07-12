using AutoMapper;

namespace GP.SS.Api.Mappings
{
    public class BusinessMappers : Profile
    {
        public BusinessMappers()
        {
            CreateMap<Infrastructure.SaldeoSmart.ResponseModels.Company, Domain.Company>();
        }
    }
}