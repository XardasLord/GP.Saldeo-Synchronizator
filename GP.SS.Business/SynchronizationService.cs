using System.Threading.Tasks;
using GP.SS.Infrastructure;

namespace GP.SS.Business
{
    public class SynchronizationService : ISynchronizationService
    {
        private readonly ISaldeoSmartFacade _saldeoSmartFacade;

        public SynchronizationService(ISaldeoSmartFacade saldeoSmartFacade)
        {
            _saldeoSmartFacade = saldeoSmartFacade;
        }

        public async Task SyncContractorsFromSaldeo()
        {
            var contractors = await _saldeoSmartFacade.GetContractors();

            // TODO: Update DB
        }
    }
}