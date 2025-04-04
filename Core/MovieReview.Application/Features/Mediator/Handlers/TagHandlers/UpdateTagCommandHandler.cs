using MediatR;
using MovieReview.Application.Features.Mediator.Commands.TagCommands;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.Mediator.Handlers.TagHandlers
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand>
    {
        private readonly MovieContext _context;
        public UpdateTagCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.FindAsync(request.TagId);
            values.Title = request.Title;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
