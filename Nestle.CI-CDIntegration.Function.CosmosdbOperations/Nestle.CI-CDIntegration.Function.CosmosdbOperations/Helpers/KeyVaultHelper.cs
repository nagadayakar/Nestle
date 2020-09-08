using Microsoft.Azure.KeyVault;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Helpers
{
   public class KeyVaultHelper
    {
        public static string GetKeyVaultSecretAsync(string secretKey, ILogger log)
        {
            string secretValue = string.Empty;

            try
            {
                // The next four lines of code show you how to use AppAuthentication library to fetch secrets from your key vault */
                var keyVaultKeyName = Environment.GetEnvironmentVariable(secretKey);
                AzureServiceTokenProvider azureServiceTokenProvider = new AzureServiceTokenProvider();
                KeyVaultClient keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));
                SecretBundle secret = Task.Run(() => keyVaultClient.GetSecretAsync(keyVaultKeyName)).ConfigureAwait(false).GetAwaiter().GetResult();
                secretValue = secret.Value;
            }

            // <exception cref="KeyVaultErrorException">
            // Thrown when the operation returned an invalid status code
            // </exception>
            catch (KeyVaultErrorException keyVaultException)
            {
                log.LogCritical(keyVaultException, $"Print vendor ASN->Key vault error | Vault Secret URI is {secretKey}");

                throw keyVaultException;
            }

            return secretValue;
        }
    }
}
