namespace Forum.Components.Models;

public class ThreadModel
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;

    public string? Summary { get; set; }

    public string AuthorId { get; set; } = string.Empty;

    public int CategoryId { get; set; }

    public List<string> Tags { get; set; } = [];

    public DateTime CreatedAt { get; set; }

    public DateTime LastActivityAt { get; set; }

    public DateTime? PinnedAt { get; set; }

    public bool IsPinned { get; set; }

    public bool IsLocked { get; set; }

    public int ReplyCount { get; set; }

    public int ViewCount { get; set; }

    public int LikeCount { get; set; }

    public double Score { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsReported { get; set; }
}
