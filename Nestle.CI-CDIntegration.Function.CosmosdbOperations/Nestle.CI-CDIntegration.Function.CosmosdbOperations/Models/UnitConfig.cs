using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
   public class UnitConfig
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string environment { get; set; }
        public List<Assignment> assignment { get; set; }
        public PolicyTypeConfig policyTypeConfig { get; set; }
        public List<AssignmentParam> assignmentParams { get; set; }
    }
}
