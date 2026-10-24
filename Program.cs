using Microsoft.EntityFrameworkCore;
using ReadMoreBooks.Data;
using ReadMoreBooks.Models;

using var db = new BookstoreContext();

Console.WriteLine($"Database exists / can connect: {db.Database.CanConnect()}");

if (!db.Books.Any())
{
    var author = new Author
    {
        FirstName = "George",
        LastName = "Orwell",
        Email = "george@example.com",
        Biography = "English novelist and essayist.",
        DateOfBirth = new DateTime(1903, 6, 25)
    };

    var category = new Category
    {
        Name = "Dystopian",
        Description = "Dark futuristic fiction",
        IsActive = true
    };

    db.Books.Add(new Book
    {
        Title = "1984",
        Isbn = "9780451524935",
        Price = 12.99m,
        Pages = 328,
        PublishedYear = 1949,
        InStock = true,
        Author = author,
        Category = category
    });

    db.SaveChanges();
    Console.WriteLine("Sample data inserted.");
}

var books = db.Books
    .Include(b => b.Author)
    .Include(b => b.Category)
    .ToList();

foreach (var b in books)
    Console.WriteLine($"{b.Title} | {b.Author.FirstName} {b.Author.LastName} | {b.Category.Name} | ${b.Price} | In stock: {b.InStock}");