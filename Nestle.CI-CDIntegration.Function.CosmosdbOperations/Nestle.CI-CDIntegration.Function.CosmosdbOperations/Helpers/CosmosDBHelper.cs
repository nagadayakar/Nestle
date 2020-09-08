using System;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models;
using System.Linq.Expressions;
using Microsoft.Azure.Documents.Linq;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Helpers
{

    public class CosmosDBHelper : ICosmosDBHelper
    {


        private readonly DocumentClient _client;
        private readonly string _accountUrl;
        private readonly string _primarykey;
        private static readonly FeedOptions DefaultOptions = new FeedOptions { EnableCrossPartitionQuery = true };
        public CosmosDBHelper(ILogger log)
        {

            _accountUrl = KeyVaultHelper.GetKeyVaultSecretAsync("cosmosDBEndPointUrl", log);
            _primarykey = KeyVaultHelper.GetKeyVaultSecretAsync("CosmosDBAuthorizationKey", log);
            _client = new DocumentClient(new Uri(_accountUrl), _primarykey);
        }

        public async Task<dynamic> GetData(string policyName, ILogger log)
        {
            try
            {
                //var result = await _client.ReadDocumentFeedAsync(UriFactory.CreateDocumentCollectionUri(dbName, name),
                //    new FeedOptions { MaxItemCount = 10 });
                var cosmosDbName = Environment.GetEnvironmentVariable(Constant.CosmosDBNameKey);
                var cosmosDbDocumentListName = Environment.GetEnvironmentVariable(Constant.PolicyDocumentListNameKey);
                var CosmosDBcollectionUri = UriFactory.CreateDocumentCollectionUri(cosmosDbName, cosmosDbDocumentListName);

                var policy = _client.CreateDocumentQuery<dynamic>(CosmosDBcollectionUri,
                   $"SELECT * FROM p WHERE p.policyname = '{policyName}'", DefaultOptions).ToList();
                return policy;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //private static DocumentClient client;
        //    static Uri CosmosDBcollectionUri;
        //    // Set to true for this sample since it deals with different kinds of queries.
        //    private static readonly FeedOptions DefaultOptions = new FeedOptions { EnableCrossPartitionQuery = true };
        //    string databaseName = Environment.GetEnvironmentVariable("policycontainer");
        //    string collectionName = Environment.GetEnvironmentVariable("policy");
        //    public DocumentClient GetCosmosDBURIAsync(ILogger log)
        //    {

        //        var endpointUrl = KeyVaultHelper.GetKeyVaultSecretAsync("cosmosDBEndPointUrl", log);
        //        var authorizationKey = KeyVaultHelper.GetKeyVaultSecretAsync("CosmosDBAuthorizationKey", log);
        //        //Get a Document client
        //        client = new DocumentClient(new Uri(endpointUrl), authorizationKey,
        //            new ConnectionPolicy
        //            {
        //                ConnectionMode = ConnectionMode.Gateway,
        //                ConnectionProtocol = Protocol.Https
        //            });
        //        {
        //            Initialize(databaseName, collectionName).Wait();
        //        }
        //        return client;
        //    }

        //    private static async Task Initialize(string databaseId, string collectionId)
        //    {
        //        Database database = await client.CreateDatabaseIfNotExistsAsync(new Database { Id = databaseId });
        //        //DocumentCollection collection = await GetOrCreateCollectionAsync(databaseId, collectionId);

        //        //var documentCollectionResponse = await client.ReadDocumentCollectionAsync(CosmosDBcollectionUri);
        //        //DocumentCollection documentCollectionResource = documentCollectionResponse.Resource;
        //    }
        //    private static async Task<DocumentCollection> GetOrCreateCollectionAsync(string databaseId, string collectionId)
        //    {
        //        DocumentCollection collectionDefinition = new DocumentCollection();
        //        collectionDefinition.Id = collectionId;
        //        collectionDefinition.IndexingPolicy = new IndexingPolicy(new RangeIndex(DataType.String) { Precision = -1 });
        //        collectionDefinition.PartitionKey.Paths.Add("/policyname");

        //        return await client.CreateDocumentCollectionIfNotExistsAsync(
        //            UriFactory.CreateDatabaseUri(databaseId),
        //            collectionDefinition,
        //            new RequestOptions { OfferThroughput = 400 });
        //    }

        //    public Policy GetPolicyDocumentAsync(string policyName, ILogger log)
        //    {
        //        client = GetCosmosDBURIAsync(log);
        //        CosmosDBcollectionUri = UriFactory.CreateDocumentCollectionUri(databaseName, collectionName);
        //        var policy = client.CreateDocumentQuery<Policy>(
        //           CosmosDBcollectionUri,
        //           "SELECT * FROM p WHERE p.policyname='policylocation'", DefaultOptions).ToList();




        //        var policyDetils = policy[0];

        //        var query =
        //           from p in client.CreateDocumentQuery<Policy>(CosmosDBcollectionUri, DefaultOptions)
        //           where p.PolicyName == "policylocation"
        //           select new { id = p.Id, policyName = p.PolicyName };
        //        foreach (var item in query.ToList())
        //        {
        //            Console.WriteLine("The {0} policy unitconfig {1}", item.id, item.policyName);
        //        }
        //        return policyDetils;
        //        // var documentQuery = client.CreateDocumentQuery(CosmosDBcollectionUri,
        //        // $"SELECT * FROM p WHERE p.policyName = '{policyName}'",
        //        //  new FeedOptions()
        //        //  {
        //        //      EnableCrossPartitionQuery = true,
        //        //      MaxItemCount = 1,
        //        //  })
        //        // .AsDocumentQuery();
        //        //    while (documentQuery.HasMoreResults)
        //        //    {
        //        //        foreach (var policy in documentQuery.ExecuteNextAsync().Result)
        //        //        {
        //        //            Console.WriteLine(
        //        //                 $"The document with the following title exists: {policyName}");
        //        //            Console.WriteLine(policy);
        //        //            return policy;
        //        //        }
        //        //    }
        //        //    return null;
        //        //}
        //    }

        //    public void InsertPolicy(Policy policyDocument)
        //    {

        //    }


    }
}
