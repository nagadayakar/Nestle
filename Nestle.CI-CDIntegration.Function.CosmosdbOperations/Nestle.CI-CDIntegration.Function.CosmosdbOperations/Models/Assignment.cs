using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
    public class Assignment
    {
        public string id { get; set; }
        public string name { get; set; }
        public string policyId { get; set; }
        public string unitId { get; set; }
        public string scope { get; set; }
        public string enforcementMode { get; set; }
        public string status { get; set; }
        public bool readyForNextStage { get; set; }
        public List<object> remediationTask { get; set; }
        public List<object> complianceSummary { get; set; }
        public List<object> auditEvent { get; set; }
        public string currentEffect { get; set; }
        public string nextEffect { get; set; }
        public string currentStage { get; set; }
        public DateTime currentStageStartDate { get; set; }
        public string nextStage { get; set; }
        public DateTime nextStageEffectDate { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime lastUpdatedDate { get; set; }
        public string lastUpdatedBy { get; set; }
        public string assignmentJson { get; set; }


       
        
        

    }
}
