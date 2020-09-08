using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
    
   public class Policy
    {
        public string Id { get; set; }
        public string PolicyName { get; set; }
        public string Description { get; set; }
        public string PolicyRequestor { get; set; }
        public string DeploymentDate { get; set; }
        public string Version { get; set; }
        public string TargetEffect { get; set; }
        public string PolicyType { get; set; }
        public string Status { get; set; }
        public bool ReadyForNextStage { get; set; }
        public bool Isinitiative { get; set; }
        public object AssignmentJson { get; set; }
        public string DisplayName { get; set; }
        public AppSettingsConfig AppSettingsConfig { get; set; }
        public UnitConfig UnitConfig { get; set; }
        public List<ExceptionTagRequest> ExceptionTagRequests { get; set; }
        public EmailTemplateConfig EmailTemplateConfig { get; set; }
        public List<WorkflowScheduleConfig> WorkflowScheduleConfig { get; set; }
    }
}
