using MovieReview.Application.Features.CQRS.Commands.CategoryCommands;
using MovieReview.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReview.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly MovieContext _movieContext;

        public UpdateCategoryCommandHandler(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async void Handle(UpdateCategoryCommand command)
        {
            var value = await _movieContext.Categories.FindAsync(command.Id);

            value.CategoryName = command.CategoryName;

            await _movieContext.SaveChangesAsync();

        }
    }
}
