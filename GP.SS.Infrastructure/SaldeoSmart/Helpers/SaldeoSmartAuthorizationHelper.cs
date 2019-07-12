using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GP.SS.Infrastructure.SaldeoSmart.Helpers
{
	public class SaldeoSmartAuthorizationHelper : ISaldeoSmartAuthorizationHelper
	{
		public SaldeoSmartAuthorizationHelper()
		{
		}

		public string GenerateRequestSignatureHash(IDictionary<string, string> parameters, string apiKey)
		{
			var sb = new StringBuilder();

			foreach (var parameter in parameters.OrderBy(key => key.Key))
			{
				sb.Append(parameter.Key).Append("=").Append(parameter.Value);
			}

			var baseSignature = sb.ToString();

			baseSignature = baseSignature
				.Replace("=", "%3D")
				.Replace(":", "%3A");

			baseSignature = baseSignature + apiKey;

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