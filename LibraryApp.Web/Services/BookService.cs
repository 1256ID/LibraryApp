using LibraryApp.Web.Models;

namespace LibraryApp.Web.Services;

public class BookService
{
    private List<Book> books =
    [
            new Book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Description = "A tragic story of Jay Gatsby and his unrelenting passion for Daisy Buchanan, set in the Roaring Twenties."
            },
            new Book
            {
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                Description = "A powerful novel about racial injustice and childhood innocence in the Deep South, told through the eyes of young Scout Finch."
            },
            new Book
            {
                Title = "1984",
                Author = "George Orwell",
                Description = "A dystopian tale about a totalitarian regime that uses surveillance and propaganda to control its citizens."
            },
            new Book
            {
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                Description = "A romantic and witty exploration of love, class, and family through the life of Elizabeth Bennet."
            },
            new Book
            {
                Title = "The Hobbit",
                Author = "J.R.R. Tolkien",
                Description = "A fantasy adventure following Bilbo Baggins on a quest to reclaim a lost dwarf kingdom from a fearsome dragon."
            },
            new Book
            {
                Title = "Brave New World",
                Author = "Aldous Huxley",
                Description = "A futuristic vision of a society driven by technological advancements, conformity, and artificial happiness."
            }
    ];

    public void Add(Book book) => books.Add(book);
    public Book? GetById(Guid id) => books.SingleOrDefault(c => c.Equals(id));
    public Book[] GetAll() => [.. books];
    public void Remove(Book book) => books.Remove(book);
}
