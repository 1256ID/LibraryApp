namespace LibraryApp.Web.Models;

public class Book
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Title { get; set; }
    public string? Description { get; set; }
}
