using System.Diagnostics;
using System.Threading.Tasks;
using Quartz;

namespace GP.SS.Business.Jobs
{
    public class SynchronizeSaldeoCompaniesJob : IJob
    {
        private readonly ISynchronizationService _synchronizationService;

        public SynchronizeSaldeoCompaniesJob(ISynchronizationService synchronizationService)
        {
            _synchronizationService = synchronizationService;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            // TODO: LOGGER START
            Debug.WriteLine("SyncCompaniesFromSaldeo STARTED");

            await _synchronizationService.SyncCompaniesFromSaldeo();

            // TODO: LOGGER STOP
            Debug.WriteLine("SyncCompaniesFromSaldeo STOPPED");
        }
    }
}
