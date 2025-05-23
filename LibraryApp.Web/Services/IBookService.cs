using LibraryApp.Web.Models;
namespace LibraryApp.Web.Services
{
    public interface IBookService
    {
        public void Add(Book book);
        public void Update(Book book);
        public Book GetById(int id);
        public Book[] GetAll();
        public void Remove(Book book);
    }
}
