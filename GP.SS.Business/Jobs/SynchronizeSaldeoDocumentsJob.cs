using System.Threading.Tasks;
using Coravel.Invocable;
using Microsoft.Extensions.Logging;

namespace GP.SS.Business.Jobs
{
    public class SynchronizeSaldeoDocumentsJob : IInvocable
    {
        private readonly ISynchronizationService _synchronizationService;
        private readonly ILogger<SynchronizeSaldeoCompaniesJob> _logger;

        public SynchronizeSaldeoDocumentsJob(ISynchronizationService synchronizationService, ILogger<SynchronizeSaldeoCompaniesJob> logger)
        {
            _synchronizationService = synchronizationService;
            _logger = logger;
        }

        public async Task Invoke()
        {
            _logger.LogInformation("SyncDocumentsFromSaldeo STARTED");

            await _synchronizationService.SyncDocumentsFromSaldeo();

            _logger.LogInformation("SyncDocumentsFromSaldeo FINISHED");
        }
    }
}