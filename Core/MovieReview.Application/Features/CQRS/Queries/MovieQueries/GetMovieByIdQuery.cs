namespace MovieReview.Application.Features.CQRS.Queries.MovieQueries
{
    public class GetMovieByIdQuery
    {
        public int MovieId { get; set; }

        public GetMovieByIdQuery(int movieId)
        {
            MovieId = movieId;
        }
    }
}
