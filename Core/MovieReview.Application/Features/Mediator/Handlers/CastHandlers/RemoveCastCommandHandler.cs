using MediatR;
using MovieReview.Application.Features.Mediator.Commands.CastCommands;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.Mediator.Handlers.CastHandlers;

public class RemoveCastCommandHandler : IRequestHandler<RemoveCastCommand>
{
    private readonly MovieContext _context;

    public RemoveCastCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(RemoveCastCommand request, CancellationToken cancellationToken)
    {
        var values = await _context.Casts.FindAsync(request.CastId);
        if (values != null)
        {
            _context.Casts.Remove(values);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
