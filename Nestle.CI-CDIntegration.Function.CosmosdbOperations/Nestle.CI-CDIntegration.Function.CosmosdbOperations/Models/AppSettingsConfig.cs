using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
   public class AppSettingsConfig
    {
        public bool sendEmailBeforeEffectChange { get; set; }
        public string effectUpgradePrenotificationDays { get; set; }
        public string emailTemplatePath { get; set; }
        public string nonComplianceReportingWeekDay { get; set; }
        public string exceptionTagReportingWeekDay { get; set; }
        public bool isGateEmailEnabled { get; set; }
        public bool isEmailSendAfterPolicyDeployment { get; set; }
    }
}
