namespace bookepub.Models;

public class Admin
{
    public int AdminId { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Role { get; set; }
}