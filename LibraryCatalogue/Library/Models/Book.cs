using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Library.DAL;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Models;

public class Book
{
    [Key]
    public int BookId { get; set; }
    [Display(Name = "Title")]
    public string Title { get; set; }
    [Display(Name = "Author")]
    public Author Author { get; set; }

    [NotMapped]
    public IEnumerable<SelectListItem> AuthorList
    {
        get
        {
            using var context = new LibraryContext();
            return context.Authors.ToList().Select(x => new SelectListItem
            {
                Value = x.ID.ToString(),
                Text = x.Name
            });
        }
    }
}