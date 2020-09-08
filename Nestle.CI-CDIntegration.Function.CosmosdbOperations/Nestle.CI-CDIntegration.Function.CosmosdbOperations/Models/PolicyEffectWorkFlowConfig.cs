using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
   public class PolicyEffectWorkFlowConfig
    {
        public string policyType { get; set; }
        public string unitId { get; set; }
        public string stage { get; set; }
        public string order { get; set; }
        public string maximumDuration { get; set; }
        public List<object> policyStageConfig { get; set; }
    }
}
