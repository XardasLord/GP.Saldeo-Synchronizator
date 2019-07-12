using System;
using System.Text;
using System.Threading.Tasks;
using GP.SS.Common;
using Microsoft.Extensions.Options;
using RestSharp;
using RestSharp.Extensions;

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

            var requestId = Guid.NewGuid().ToString();
            var signatureHash = GenerateRequestSignatureHash(_saldeoSmartSettings.Value.Username, requestId);

            request.AddParameter("username", _saldeoSmartSettings.Value.Username);
            request.AddParameter("req_id", requestId);
            request.AddParameter("req_sig", signatureHash);

            var response = await client.ExecuteTaskAsync(request);

            throw new System.NotImplementedException();
        }

        private string GenerateRequestSignatureHash(string username, string requestId)
        {
	        var sb = new StringBuilder();

	        sb.Append("username").Append("=").Append(username);
	        sb.Append("req_id").Append("=").Append(requestId);

	        var baseSignature = sb.ToString();

	        baseSignature = baseSignature.UrlEncode(Encoding.UTF8);

	        var calculatedSignatureHash = CalculateMD5Hash(baseSignature);

	        return calculatedSignatureHash;
        }

        private string CalculateMD5Hash(string input)
        {
	        // step 1, calculate MD5 hash from input
	        var md5 = System.Security.Cryptography.MD5.Create();
	        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
	        byte[] hash = md5.ComputeHash(inputBytes);

	        // step 2, convert byte array to hex string
	        StringBuilder sb = new StringBuilder();
	        for (int i = 0; i < hash.Length; i++)
	        {
		        sb.Append(hash[i].ToString("X2"));
	        }
	        return sb.ToString();
        }
	}
}