using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Helpers
{
    public interface ICosmosDBHelper
    {
        //DocumentClient GetCosmosDBURIAsync(ILogger log);
        //Policy GetPolicyDocumentAsync(string policyName, ILogger log);

        Task<dynamic> GetData(string policyName, ILogger log);
    }
}
