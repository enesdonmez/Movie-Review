using MovieReview.Application.Features.CQRS.Commands.CategoryCommands;
using MovieReview.Domain.Entities;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly MovieContext _movieContext;

        public CreateCategoryCommandHandler(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task Handle(CreateCategoryCommand command)
        {
            _movieContext.Categories.Add( new Category
            {
                CategoryName = command.CategoryName

            });

            await _movieContext.SaveChangesAsync();
        }
    }
}
