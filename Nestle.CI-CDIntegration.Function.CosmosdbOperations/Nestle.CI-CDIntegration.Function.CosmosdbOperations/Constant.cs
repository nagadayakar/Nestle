using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations
{
    public static class Constant
    {
        public static string CosmosDBNameKey = "cosmosDbDatabaseName";
        public static string PolicyDocumentListNameKey = "policyDocumentListName";

        // var policyDocumentInformation = _client.CreateDocumentQuery<Policy>(
        //UriFactory.CreateDocumentCollectionUri(cosmosDbName, cosmosDbDocumentListName),DefaultOptions)
        //.Where(so => so.PolicyName == policyName)
        //.AsEnumerable()
        //.First();
    }
}
