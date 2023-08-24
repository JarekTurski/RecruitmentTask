using System.ComponentModel.DataAnnotations;

namespace GitlabClient.Models
{
    public class CreateIssueModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
