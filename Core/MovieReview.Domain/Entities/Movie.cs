namespace MovieReview.Domain.Entities;

public class Movie
{
    public int MovieId { get; set; }
    public string Title { get; set; }
    public string CoverImageUrl { get; set; }
    public decimal Rating { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string CreatedYear { get; set; }
    public bool Status { get; set; }
}
