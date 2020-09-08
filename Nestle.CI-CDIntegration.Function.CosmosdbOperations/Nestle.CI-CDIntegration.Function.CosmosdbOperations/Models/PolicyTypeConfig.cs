using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
    public class PolicyTypeConfig
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool hasArm { get; set; }
        public string emailTemplateId { get; set; }
        //public List<PolicyEffectWorkFlowConfig> policyEffectWorkFlowConfig { get; set; }
       

    }
}
