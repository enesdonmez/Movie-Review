using MovieReview.Application.Features.CQRS.Commands.MovieCommands;
using MovieReview.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReview.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHandler
    {
        private readonly MovieContext _movieContext;

        public RemoveMovieCommandHandler(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async void Handle(RemoveMovieCommand command)
        {
            await _movieContext.Movies.FindAsync(command.MovieId);

            _movieContext.Remove(command);

            await _movieContext.SaveChangesAsync();
        }
    }
}
