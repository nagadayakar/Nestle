using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
    public class ExceptionTagRequest
    {
        public string Id { get; set; }
        public string ExceptionTagRequestor { get; set; }

        public string ExceptionTagApprover { get; set; }
        public string PolicyId { get; set; }
        public string ResourceId { get; set; }
        public string SnowId { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestStatus { get; set; }
        public DateTime TagInsertDate { get; set; }
        public DateTime TagExpiryDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
