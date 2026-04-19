namespace Forum.Components.Models;

public class PostModel
{
    public int Id { get; set; }

    public int ThreadId { get; set; }
    public string AuthorId { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
    public DateTime? EditedAt { get; set; }

    public int LikeCount { get; set; }

    public bool IsDeleted { get; set; }
    public bool IsEdited { get; set; }

    public int? ParentPostId { get; set; }
}
