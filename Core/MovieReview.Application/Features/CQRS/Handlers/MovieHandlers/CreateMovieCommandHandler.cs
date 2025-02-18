using MovieReview.Application.Features.CQRS.Commands.MovieCommands;
using MovieReview.Domain.Entities;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _movieContext;

        public CreateMovieCommandHandler(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task Handle(CreateMovieCommand command)
        {
            _movieContext.Movies.Add(new Movie
            {
                Title = command.Title,
                CoverImageUrl = command.CoverImageUrl,
                CreatedYear = command.CreatedYear,
                Description = command.Description,
                Duration = command.Duration,
                Rating = command.Rating,
                ReleaseDate = command.ReleaseDate,
                Status = command.Status,

            });

            await _movieContext.SaveChangesAsync();
        }
    }
}
