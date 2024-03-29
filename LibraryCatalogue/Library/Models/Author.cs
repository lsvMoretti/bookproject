﻿using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Author
{
    [Key]
    public int ID { get; set; }
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    public virtual ICollection<Book>? Books { get; set; }

    public string Name => $"{FirstName} {LastName}";
}