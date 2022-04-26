using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL;

public class LibraryContext : DbContext
{
    public LibraryContext()
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=(localdb)\mssqllocaldb;Database=LibraryDb;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}