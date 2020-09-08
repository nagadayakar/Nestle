using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
    public class AssignmentParams
    {
        //public string policyAssignentMode { get; set; }
        public string policyId { get; set; }
        public string policyUnitId { get; set; }
        public string parameterName { get; set; }
        public string parameterValue { get; set; }
    }
}
