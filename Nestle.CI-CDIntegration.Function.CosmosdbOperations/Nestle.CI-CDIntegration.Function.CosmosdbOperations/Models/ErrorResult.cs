using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
    [JsonObject(Title = "error")]
    public class ErrorResult
    {
        private int _errorCode;
        private string _errorDescription;

        public ErrorResult()
        {
        }
        public ErrorResult(int errorCode, string errorDescription)
        {
            _errorCode = errorCode;
            _errorDescription = errorDescription;
        }

        [JsonProperty("errorCode")]
        public int ErrorCode
        {
            get
            {
                return _errorCode;
            }
            set
            {
                _errorCode = value;
            }
        }

        [JsonProperty("errorDescription")]
        public string ErrorDescription
        {
            get
            {
                return _errorDescription;
            }
            set
            {
                _errorDescription = value;
            }
        }
    }
}
