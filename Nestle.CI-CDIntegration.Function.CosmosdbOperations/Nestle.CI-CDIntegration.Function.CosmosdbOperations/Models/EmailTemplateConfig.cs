using System;
using System.Collections.Generic;
using System.Text;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
    public class EmailTemplateConfig
    {
        //public List<EmailRequest> EmailRequests { get; set; }
        public string id { get; set; }
        public string templateId { get; set; }
        public string template { get; set; }
        public string dataQuery { get; set; }
        public List<object> notificationRequest { get; set; }

    }
}
