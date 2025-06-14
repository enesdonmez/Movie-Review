namespace MovieReview.Domain.Entities
{
    public class RelatedMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public bool IsWatch { get; set; }
    }
}
