namespace MovieReview.Application.Features.CQRS.Commands.MovieCommands
{
    public class RemoveMovieCommand
    {
        public int MovieId { get; set; }

        public RemoveMovieCommand(int movieId)
        {
            MovieId = movieId;
        }
    }
}
