using System.Threading.Tasks;
using Coravel.Invocable;
using Microsoft.Extensions.Logging;

namespace GP.SS.Business.Jobs
{
    public class SynchronizeSaldeoContractorsJob : IInvocable
    {
        private readonly ISynchronizationService _synchronizationService;
        private readonly ILogger<SynchronizeSaldeoCompaniesJob> _logger;

        public SynchronizeSaldeoContractorsJob(ISynchronizationService synchronizationService, ILogger<SynchronizeSaldeoCompaniesJob> logger)
        {
            _synchronizationService = synchronizationService;
            _logger = logger;
        }

        public async Task Invoke()
        {
            _logger.LogInformation("SyncContractorsFromSaldeo STARTED");

            await _synchronizationService.SyncContractorsFromSaldeo();

            _logger.LogInformation("SyncContractorsFromSaldeo FINISHED");
        }
    }
}
