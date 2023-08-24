using System.ComponentModel.DataAnnotations;

namespace GithubClient.Models
{
    public class CreateIssueModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
    }
}
