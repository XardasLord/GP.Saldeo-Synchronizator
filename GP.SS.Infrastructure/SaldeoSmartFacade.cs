using System.Threading.Tasks;
using GP.SS.Common;
using Microsoft.Extensions.Options;
using RestSharp;

namespace GP.SS.Infrastructure
{
    public class SaldeoSmartFacade : ISaldeoSmartFacade
    {
        private readonly IOptions<SaldeoSmartSettings> _saldeoSmartSettings;

        public SaldeoSmartFacade(IOptions<SaldeoSmartSettings> saldeoSmartSettings)
        {
            _saldeoSmartSettings = saldeoSmartSettings;
        }

        public async Task<object> GetContractors()
        {
            var client = new RestClient(_saldeoSmartSettings.Value.ApiUrl);
            var request = new RestRequest(_saldeoSmartSettings.Value.GetContractorsResource, Method.GET);

            var response = await client.ExecuteTaskAsync(request);

            throw new System.NotImplementedException();
        }
    }
}