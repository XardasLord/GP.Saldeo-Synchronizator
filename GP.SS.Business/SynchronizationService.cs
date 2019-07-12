using System.Threading.Tasks;
using GP.SS.Infrastructure.SaldeoSmart;

namespace GP.SS.Business
{
	public class SynchronizationService : ISynchronizationService
	{
		private readonly ISaldeoSmartFacade _saldeoSmartFacade;

		public SynchronizationService(ISaldeoSmartFacade saldeoSmartFacade)
		{
			_saldeoSmartFacade = saldeoSmartFacade;
		}

		public async Task SyncCompaniesFromSaldeo()
		{
			var companies = await _saldeoSmartFacade.GetCompanies();

			// TODO: Update DB
		}

		public async Task SyncContractorsFromSaldeo()
		{
			var contractors = await _saldeoSmartFacade.GetContractors();

			// TODO: Update DB
		}
	}
}