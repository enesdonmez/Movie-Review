using MediatR;
using MovieReview.Application.Features.Mediator.Commands.CastCommands;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.Mediator.Handlers.CastHandlers;

public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand>
{
    private readonly MovieContext _context;

    public UpdateCastCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
    {
        var values = await _context.Casts.FindAsync(request.CastId);
        if (values != null)
        {
            values.Name = request.Name;
            values.Surname = request.Surname;
            values.ImageUrl = request.ImageUrl;
            values.Overview = request.Overview;
            values.Biography = request.Biography;
            values.Title = request.Title;

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
