using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
    public class Assignment
    {
        public string scope { get; set; }
        public string enforcementMode { get; set; }
        public string status { get; set; }
        public bool readyForNextStage { get; set; }
        public List<object> remediationtask { get; set; }
        public List<object> complianceSummary { get; set; }
        public List<object> auditEvent { get; set; }
    }
}
