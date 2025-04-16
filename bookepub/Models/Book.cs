namespace bookepub.Models;

public class Book
{
    public int BookId { get; set; }
    public required string Title { get; set; }
    public string? ISBN { get; set; }
    public  int? PublisherId { get; set; }
    public required decimal Price { get; set; }    
    public  string? Description { get; set; }
    public required bool IsBestseller { get; set; }
    public required bool IsAwardWinner { get; set; }
    public DateTime? PublicationDate { get; set; }
    public required DateTime AddedDate { get; set; }
    public required bool ComingSoon { get; set; }
    public DateTime? ReleaseDate { get; set; }
    
    
    
    
}