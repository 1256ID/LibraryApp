using LibraryApp.Web.Models;
using LibraryApp.Web.Services;
using LibraryApp.Web.Views.Book;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace LibraryApp.Web.Controllers
{
    public class BookController (IBookService bookService) : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Book[] books = bookService.GetAll();
            var viewModel = new IndexVM()
            {
                BookVMs = books
              .Select(e => new IndexVM.BookVM()
              {   
                  Id = e.Id,
                  Title = e.Title,
                  Author = e.Author,
                  Description = e.Description                
              })
              .ToArray()
            };

            return View(viewModel);
        }

        [HttpGet("/details/{id}")]
        public IActionResult Details(int id) 
        {       
            var model = bookService.GetById(id);

            DetailsVM viewModel = new()
            {  
                Id = model.Id,
                Title = model.Title,
                Author = model.Author,
                Description = model.Description
            };

            return View(viewModel);
        }
        
        [HttpGet("/create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("/create")]
        public IActionResult Create(CreateVM viewModel)
        {
            if (!ModelState.IsValid)
                return View();

            Book book = new()
            {
                Title = viewModel.Title,
                Author = viewModel.Author,
                Description = viewModel.Description
            };

            bookService.Add(book);
            return RedirectToAction(nameof(Index));
        }

        [HttpPut("/details/{id}/edit")]
        public IActionResult Edit(DetailsVM viewModel, int id)
        {
            if (!ModelState.IsValid)
                return View();       
            
            Book book = new()
            {
                Id = id,
                Title = viewModel.Title,
                Author = viewModel.Author,
                Description = viewModel.Description
            };

            bookService.Update(book);
            return RedirectToAction(nameof(Index));
        }
        /*
         * 
        [HttpDelete("/remove")]
        public IActionResult Remove(Book book)
        {
            if (!ModelState.IsValid)
                return View();

            bookService.Add(book);
            return RedirectToAction(nameof(Index));
        }

        */
    }
}
