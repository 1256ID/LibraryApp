using LibraryApp.Web.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LibraryApp.Web.Services;

public class BookService : IBookService
{
    readonly List<Book> books =
    [
            new Book
            {
                Id = 1,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Description = "A tragic story of Jay Gatsby and his unrelenting passion for Daisy Buchanan, set in the Roaring Twenties."
            },
            new Book
            {
                Id = 2,
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                Description = "A powerful novel about racial injustice and childhood innocence in the Deep South, told through the eyes of young Scout Finch."
            },
            new Book
            {
                Id = 3,
                Title = "1984",
                Author = "George Orwell",
                Description = "A dystopian tale about a totalitarian regime that uses surveillance and propaganda to control its citizens."
            },
            new Book
            {
                Id = 4,
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                Description = "A romantic and witty exploration of love, class, and family through the life of Elizabeth Bennet."
            },
            new Book
            {
                Id = 5,
                Title = "The Hobbit",
                Author = "J.R.R. Tolkien",
                Description = "A fantasy adventure following Bilbo Baggins on a quest to reclaim a lost dwarf kingdom from a fearsome dragon."
            },
            new Book
            {
                Id = 6,
                Title = "Brave New World",
                Author = "Aldous Huxley",
                Description = "A futuristic vision of a society driven by technological advancements, conformity, and artificial happiness."
            }
    ];

    public void Add(Book book) 
    {
        book.Id = books.Any() ? books.Max(b => b.Id) + 1 : 1;
        books.Add(book);
    } 

    public void Update(Book book)
    {
        if (book != null)
        {
            Book? currentBook = books.SingleOrDefault(c => c.Id == book.Id);
            currentBook = book;
        }
    }
   
    public Book GetById(int id) => books.Single(e => e.Id == id);

    public Book[] GetAll() => [.. books];
    public void Remove(Book book) => books.Remove(book);

    
}
