using MediatR;
using MovieReview.Application.Features.Mediator.Commands.CastCommands;
using MovieReview.Domain.Entities;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.Mediator.Handlers.CastHandlers;

public class CreateCastCommandHandler : IRequestHandler<CreateCastCommand>
{
    private readonly MovieContext _context;

    public CreateCastCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
    {
        _context.Casts.Add(new Cast
        {
            Title = request.Title,
            Name = request.Name,
            Surname = request.Surname,
            ImageUrl = request.ImageUrl,
            Overview = request.Overview,
            Biography = request.Biography

        });

        await _context.SaveChangesAsync(cancellationToken);
    }
}
