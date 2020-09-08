using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Nestle.CI_CDIntegration.Function.CosmosdbOperations.Helpers;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations
{
    public static class CosmosDBGetPolicyDocument
    {
        [FunctionName("AzGetPolicyDocument")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string policyName = req.Query["policyName"];

            ICosmosDBHelper cosmosDBHelper = new CosmosDBHelper(log);
            var policyDocument = cosmosDBHelper.GetData(policyName, log);


            return new OkObjectResult(policyDocument);
        }
    }
}
