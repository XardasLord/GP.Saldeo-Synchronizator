using System.Diagnostics;
using System.Threading.Tasks;
using Coravel.Invocable;

namespace GP.SS.Business.Jobs
{
    public class SynchronizeSaldeoCompaniesJob : IInvocable
    {
        private readonly ISynchronizationService _synchronizationService;

        public SynchronizeSaldeoCompaniesJob(ISynchronizationService synchronizationService)
        {
            _synchronizationService = synchronizationService;
        }

        public async Task Invoke()
        {
            // TODO: LOGGER START
            Debug.WriteLine("SyncCompaniesFromSaldeo STARTED");

            await _synchronizationService.SyncCompaniesFromSaldeo();

            // TODO: LOGGER STOP
            Debug.WriteLine("SyncCompaniesFromSaldeo STOPPED");
        }
    }
}
