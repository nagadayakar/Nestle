using System;

namespace Nestle.CI_CDIntegration.Function.CosmosdbOperations.Models
{
    public class EmailRequest
    {
        public string Id { get; set; }
        public string TemplateId { get; set; }

        public string PolicyId { get; set; }

        public string AssignmentId { get; set; }
        public string ReportRequestId { get; set; }

        public string To { get; set; }
        public string Cc { get; set; }
        public DateTime RequestDate { get; set; }

        public string Status { get; set; }

        public string Error { get; set; }

        public DateTime SentDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public string LastUpdatedBy { get; set; }
    }
}