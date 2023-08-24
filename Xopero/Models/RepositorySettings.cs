using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xopero.Models
{
    public class RepositorySettings
    {
        public string GetIssuesEndpoint { get; set; }
        public string CreateIssueEndpoint { get; set; }
        public string UpdateIssueEndpoint { get; set; }
        public string CloseIssueEndpoint { get; set; }
        public string DataToUploadPath { get; set; }
        public string DataToSavePath { get; set; }

    }
}
