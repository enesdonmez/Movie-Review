using MovieReview.Application.Features.CQRS.Commands.CategoryCommands;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly MovieContext _movieContext;

        public UpdateCategoryCommandHandler(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task Handle(UpdateCategoryCommand command)
        {
            var value = await _movieContext.Categories.FindAsync(command.Id);

            value.CategoryName = command.CategoryName;

            await _movieContext.SaveChangesAsync();

        }
    }
}
