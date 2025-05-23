using LibraryApp.Web.Models;
using System.ComponentModel.DataAnnotations;


namespace LibraryApp.Web.Views.Book;

public class CreateVM
{
    [Required]
    public required int Id { get; set; } 

    [Required(ErrorMessage = "Title is required")]
    [Display(Name = "Title", Prompt = "Enter a Title")]
    public required string Title { get; set; }

    [Required(ErrorMessage = "Author is required")]
    [Display(Name = "Author", Prompt = "Enter a Author")]
    public required string Author { get; set; }

    [Required(ErrorMessage = "Description is required")]
    [Display(Name = "Description", Prompt = "Enter a Description")]
    public required string Description { get; set; }
}



