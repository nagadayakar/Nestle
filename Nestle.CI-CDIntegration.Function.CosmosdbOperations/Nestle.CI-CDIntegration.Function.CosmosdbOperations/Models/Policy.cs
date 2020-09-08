using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
    
   public class Policy
    {
        public string id { get; set; }
        public string policyName { get; set; }
        public string description { get; set; }
        public string policyRequestor { get; set; }
        public string policyOwner { get; set; }
        public string policyDeveloper { get; set; }
        public string policyFunctionTester { get; set; }
        public string policyAdmin { get; set; }
        public string riskFactor { get; set; }
        public string displayName { get; set; }
        public string deploymentScope { get; set; }
        public string scopeType { get; set; }
        public string deploymentDate { get; set; }
        public string version { get; set; }
        public string targetEffect { get; set; }
        public string exceptionTag { get; set; }
        public string policyType { get; set; }
        public string status { get; set; }
        public bool readyForNextstage { get; set; }
        public bool isInitiative { get; set; }
        public string policyLocation { get; set; }
        public string repoPath { get; set; }
        public object assignmentJson { get; set; }
        public string createdDate { get; set; }
        public string createdBy { get; set; }
        public string lastUpdatedDate { get; set; }
        public string lastUpdatedBy { get; set; }
        public AppSettingsConfig appSettingsConfig { get; set; }
        public UnitConfig unitConfig { get; set; }
        public EmailTemplateConfig emailTemplateConfig { get; set; }
        public List<PolicyEffectWorkFlowConfig> policyEffectWorkflowConfig { get; set; }
        public PolicyTargetScope policyTargetScope { get; set; }
        public List<ExceptionTagRequest> exceptionTagRequest { get; set; }
        public AssignmentParams assignmentParams { get; set; }
    }
}
