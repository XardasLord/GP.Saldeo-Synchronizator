using System.Threading.Tasks;

namespace GP.SS.Business
{
    public interface ISynchronizationService
	{
		Task SyncCompaniesFromSaldeo();
		Task SyncContractorsFromSaldeo();
	    Task SyncDocumentsFromSaldeo();
    }
}