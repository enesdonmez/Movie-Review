using MovieReview.Application.Features.CQRS.Commands.MovieCommands;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHandler
    {
        private readonly MovieContext _movieContext;

        public RemoveMovieCommandHandler(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task Handle(RemoveMovieCommand command)
        {
            var value = await _movieContext.Movies.FindAsync(command.MovieId);

            _movieContext.Movies.Remove(value);

            await _movieContext.SaveChangesAsync();
        }
    }
}
