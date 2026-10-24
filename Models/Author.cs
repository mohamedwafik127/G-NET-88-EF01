namespace ReadMoreBooks.Models;

public class Author
{
    public int Id { get; set; }                  
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? Biography { get; set; }       
    public DateTime DateOfBirth { get; set; }

    public List<Book> Books { get; set; } = new();
}