using MovieReview.Application.Features.CQRS.Commands.CategoryCommands;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly MovieContext _movieContext;

        public RemoveCategoryCommandHandler(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task Handle(RemoveCategoryCommand command)
        {
            var value = await _movieContext.Categories.FindAsync(command.Id);

            _movieContext.Categories.Remove(value);
            await _movieContext.SaveChangesAsync();
        }
    }
}
