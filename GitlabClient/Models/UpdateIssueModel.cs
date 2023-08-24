using System.ComponentModel.DataAnnotations;

namespace GitlabClient.Models
{
    public class UpdateIssueModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public int IssueId { get; set; }
    }
}
