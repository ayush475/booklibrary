namespace bookepub.Models;

public class Announcement
{
    public int AnnouncementId { get; set; }
    public required int AdminId { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public required DateTime PostDate { get; set; }
    public required DateTime ExpiryDate { get; set; }
    public required bool IsActive { get; set; }
    
}