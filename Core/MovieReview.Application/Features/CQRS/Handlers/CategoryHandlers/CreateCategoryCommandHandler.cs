using MovieReview.Application.Features.CQRS.Commands.CategoryCommands;
using MovieReview.Domain.Entities;
using MovieReview.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReview.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly MovieContext _movieContext;

        public CreateCategoryCommandHandler(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async void Handle(CreateCategoryCommand command)
        {
            _movieContext.Categories.Add( new Category
            {
                CategoryName = command.CategoryName

            });

            await _movieContext.SaveChangesAsync();
        }
    }
}
