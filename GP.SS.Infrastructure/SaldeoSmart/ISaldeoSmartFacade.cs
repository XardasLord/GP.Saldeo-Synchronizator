using System.Threading.Tasks;
using GP.SS.Common;
using GP.SS.Infrastructure.SaldeoSmart.ResponseDto;

namespace GP.SS.Infrastructure.SaldeoSmart
{
    public interface ISaldeoSmartFacade
    {
	    Task<ResponseDto<CompaniesDto>> GetCompanies();
        Task<object> GetContractors();
    }
}