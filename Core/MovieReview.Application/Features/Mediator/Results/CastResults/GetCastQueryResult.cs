namespace MovieReview.Application.Features.Mediator.Results.CastResults
{
    public class GetCastQueryResult
    {
        public int CastId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string? Overview { get; set; }
        public string? Biography { get; set; }
    }
}
