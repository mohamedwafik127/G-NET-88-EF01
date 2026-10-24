namespace ReadMoreBooks.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Isbn { get; set; } = null!;
    public decimal Price { get; set; }
    public int Pages { get; set; }
    public int PublishedYear { get; set; }
    public bool InStock { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; } = null!;

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}