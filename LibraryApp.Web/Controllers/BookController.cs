using LibraryApp.Web.Models;
using LibraryApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Web.Controllers
{
    public class BookController : Controller
    {
        static BookService bookService = new();
        [HttpGet("")]
        public IActionResult Index()
        {
            Book[] books = bookService.GetAll();
            return View(books);
        }
        [HttpGet("/create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("/create")]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
                return View();

            bookService.Add(book);
            return RedirectToAction(nameof(Index));
        }
    }
}
