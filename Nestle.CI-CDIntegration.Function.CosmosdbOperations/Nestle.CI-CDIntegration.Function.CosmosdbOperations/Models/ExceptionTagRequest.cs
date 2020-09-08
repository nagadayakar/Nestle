using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
    public class ExceptionTagRequest
    {
        public string id { get; set; }
        public string exceptionTagRequestor { get; set; }
        public string exceptionTagApprover { get; set; }
        public string policyId { get; set; }
        public string resourseId { get; set; }
        public string snowId { get; set; }
        public string requestDate { get; set; }
        public string requestStatus { get; set; }
        public string tagInsertDate { get; set; }
        public string tagExpiryDate { get; set; }
        public string lastUpdatedDate { get; set; }
        public string lastUpdatedBy { get; set; }
    }
}
