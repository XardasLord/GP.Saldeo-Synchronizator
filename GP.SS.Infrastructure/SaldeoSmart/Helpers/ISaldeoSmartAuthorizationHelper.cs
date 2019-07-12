using System.Collections.Generic;

namespace GP.SS.Infrastructure.SaldeoSmart.Helpers
{
	public interface ISaldeoSmartAuthorizationHelper
	{
		string GenerateRequestSignatureHash(IDictionary<string, string> parameters, string apiKey);
	}
}