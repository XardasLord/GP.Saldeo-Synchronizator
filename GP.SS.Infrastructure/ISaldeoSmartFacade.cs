using System.Threading.Tasks;

namespace GP.SS.Infrastructure
{
    public interface ISaldeoSmartFacade
    {
        Task<object> GetContractors();
    }
}