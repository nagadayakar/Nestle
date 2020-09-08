using Microsoft.Azure.Documents.Client;
using System.Threading.Tasks;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Helpers
{
    public interface ICosmosConnection
    {
        Task<DocumentClient> InitializeAsync(string collectionId);
    }
}
