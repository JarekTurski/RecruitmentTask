using System;
using System.Collections.Generic;

namespace GitlabClient.Models
{
    public class ResponseModel : HostingServiceClientBase.Models.ResponseModel<Issue>
    {
    }
    public class User
    {
        public object AvatarUrl { get; set; }
        public string WebUrl { get; set; }
        public string State { get; set; }
        public string Username { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Links
    {
        public string Self { get; set; }
        public string Notes { get; set; }
        public string AwardEmoji { get; set; }
        public string Project { get; set; }
        public string ClosedAsDuplicateOf { get; set; }
    }

    public class Milestone
    {
        public object DueDate { get; set; }
        public int ProjectId { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public int Iid { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class References
    {
        public string Short { get; set; }
        public string Relative { get; set; }
        public string Full { get; set; }
    }

    public class Issue
    {
        public int ProjectId { get; set; }
        public Milestone Milestone { get; set; }
        public User Author { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public int Iid { get; set; }
        public List<User> Assignees { get; set; }
        public User Assignee { get; set; }
        public string Type { get; set; }
        public List<string> Labels { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public int MergeRequestsCount { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ClosedAt { get; set; }
        public User ClosedBy { get; set; }
        public int UserNotesCount { get; set; }
        public string DueDate { get; set; }
        public string WebUrl { get; set; }
        public References References { get; set; }
        public TimeStats TimeStats { get; set; }
        public bool HasTasks { get; set; }
        public string TaskStatus { get; set; }
        public bool Confidential { get; set; }
        public bool DiscussionLocked { get; set; }
        public string IssueType { get; set; }
        public string Severity { get; set; }
        public Links Links { get; set; }
        public TaskCompletionStatus TaskCompletionStatus { get; set; }
    }

    public class TaskCompletionStatus
    {
        public int Count { get; set; }
        public int CompletedCount { get; set; }
    }

    public class TimeStats
    {
        public int TimeEstimate { get; set; }
        public int TotalTimeSpent { get; set; }
        public object HumanTimeEstimate { get; set; }
        public object HumanTotalTimeSpent { get; set; }
    }
}
