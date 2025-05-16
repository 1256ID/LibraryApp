using LibraryApp.Web.Models;

namespace LibraryApp.Web.Services;

public class BookService
{
    private List<Book> books =
        [
            new Book("Test1", "Info"),
            new Book("Test2", "Info2")
        ];

    public void Add(Book book) => books.Add(book);
    public Book? GetById(Guid id) => books.SingleOrDefault(c => c.Equals(id));
    public Book[] GetAll() => books.ToArray();
    public void Remove(Book book) => books.Remove(book);
}
