using MovieReview.Application.Features.CQRS.Commands.MovieCommands;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _movieContext;

        public UpdateMovieCommandHandler(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task Handle(UpdateMovieCommand command)
        {
            var value = await _movieContext.Movies.FindAsync(command.MovieId);

            value.Title = command.Title;
            value.Duration = command.Duration;
            value.Description = command.Description;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Rating = command.Rating;
            value.Status = command.Status;
            value.CreatedYear = command.CreatedYear;

            await _movieContext.SaveChangesAsync();

        }
    }
}
