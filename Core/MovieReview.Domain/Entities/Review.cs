namespace MovieReview.Domain.Entities;

public class Review
{
    public int ReviewId { get; set; }
    public string ReviewComment { get; set; }
    public int UserRating { get; set; }
    public DateTime ReviewDate { get; set; }
    public bool Status { get; set; }
}
