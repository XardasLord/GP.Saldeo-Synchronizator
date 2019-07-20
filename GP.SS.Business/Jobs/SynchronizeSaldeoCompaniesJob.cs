using System.Threading.Tasks;
using Coravel.Invocable;
using Microsoft.Extensions.Logging;

namespace GP.SS.Business.Jobs
{
    public class SynchronizeSaldeoCompaniesJob : IInvocable
    {
        private readonly ISynchronizationService _synchronizationService;
        private readonly ILogger<SynchronizeSaldeoCompaniesJob> _logger;

        public SynchronizeSaldeoCompaniesJob(ISynchronizationService synchronizationService, ILogger<SynchronizeSaldeoCompaniesJob> logger)
        {
            _synchronizationService = synchronizationService;
            _logger = logger;
        }

        public async Task Invoke()
        {
            _logger.LogInformation("SyncCompaniesFromSaldeo STARTED");

            await _synchronizationService.SyncCompaniesFromSaldeo();

            _logger.LogInformation("SyncCompaniesFromSaldeo FINISHED");
        }
    }
}
