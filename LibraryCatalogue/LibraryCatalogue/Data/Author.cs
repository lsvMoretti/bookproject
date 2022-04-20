namespace LibraryCatalog.Data;

public class Author
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public virtual ICollection<Book> Books { get; set; }
}