namespace bookepub.Models;

public class Author
{
    public int AuthorId { get; set; }
    public required string Name { get; set; }
    public string? Bio { get; set; }
}