using System.Threading.Tasks;

namespace GP.SS.Business
{
    public interface ISynchronizationService
    {
        Task SyncContractorsFromSaldeo();
    }
}