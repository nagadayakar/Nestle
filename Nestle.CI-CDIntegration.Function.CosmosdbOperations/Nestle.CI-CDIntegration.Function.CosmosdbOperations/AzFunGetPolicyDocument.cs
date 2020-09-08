using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Nestle.CI_CDIntegration.Function.CosmosdbOperations.Helpers;
using Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations
{
    public static class CosmosDBGetPolicyDocument
    {
        [FunctionName("Azfun-GetPolicyDocument")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            try
            {
                log.LogInformation("Get policy document ->Azure function is starting : " + DateTime.Now);
                string policyName = req.Query["policyName"];
                ICosmosDBHelper cosmosDBHelper = new CosmosDBHelper(log);
                var policyDocument = !string.IsNullOrEmpty(policyName)? cosmosDBHelper.GetPolicyDocument(policyName, log):null;
                if (policyDocument != null)
                {
                    return new OkObjectResult(policyDocument);
                }
                else
                {
                    var errorResult = new ErrorResult()
                    {
                        ErrorCode = 400,
                        ErrorDescription = "Document not found, check the policy name."
                    };
                    log.LogInformation($"Get Policy document from cosmos database -> Azure function failed due to invalid policy name  : '{policyName}'"+ errorResult + DateTime.Now);
                    return new BadRequestObjectResult(errorResult);
                }
            }
            catch (Exception ex)
            {
                log.LogCritical(ex, $"Get Policy document from cosmos database->Unexpected error encountered");
                var errorResult = new ErrorResult()
                {
                    ErrorCode = 400,
                    ErrorDescription = ex.Message
                };
                log.LogInformation($"Get Policy document from cosmos database -> Azure function has ended : " + errorResult + DateTime.Now);
                return new BadRequestObjectResult(errorResult);
            }
        }
    }
}
