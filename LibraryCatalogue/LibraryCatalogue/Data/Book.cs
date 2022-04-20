namespace LibraryCatalog.Data;

public class Book
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime? PublishedDate { get; set; }

    public virtual Author Author { get; set; }
}