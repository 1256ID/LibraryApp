using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Web.Models;

public class Book()
{
    [Required]
    public Guid Id { get; } = Guid.NewGuid();

    [Required(ErrorMessage = "Title is required")]
    [Display(Name = "Title", Prompt = "Enter a Title")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Author is required")]
    [Display(Name = "Author", Prompt = "Enter a Author")]
    public string? Author { get; set; }

    [Required(ErrorMessage = "Description is required")]
    [Display(Name = "Description", Prompt = "Enter a Description")]
    public string? Description { get; set; } 
}
