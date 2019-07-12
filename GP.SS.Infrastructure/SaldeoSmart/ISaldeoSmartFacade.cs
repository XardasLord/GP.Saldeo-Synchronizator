using System.Threading.Tasks;

namespace GP.SS.Infrastructure.SaldeoSmart
{
    public interface ISaldeoSmartFacade
    {
	    Task<object> GetCompanies();
        Task<object> GetContractors();
    }
}