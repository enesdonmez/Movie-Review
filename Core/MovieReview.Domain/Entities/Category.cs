namespace MovieReview.Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public bool Status { get; set; }
    public string? Description { get; set; }
    public List<Movie> Movies { get; set; }
    public List<Series> Serieses { get; set; }
}
