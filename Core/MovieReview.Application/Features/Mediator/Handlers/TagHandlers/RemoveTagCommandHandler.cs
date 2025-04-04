using MediatR;
using MovieReview.Application.Features.Mediator.Commands.TagCommands;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.Mediator.Handlers.TagHandlers
{
    public class RemoveTagCommandHandler : IRequestHandler<RemoveTagCommand>
    {
        private readonly MovieContext _context;
        public RemoveTagCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveTagCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.FindAsync(request.TagId);
            _context.Tags.Remove(values);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
