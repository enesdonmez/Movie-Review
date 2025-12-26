using MovieReview.Application.Features.CQRS.Commands.SeriesCommands;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.SeriesHandlers;

public class RemoveSeriesCommandHandler
{
    private readonly MovieContext _context;
    public RemoveSeriesCommandHandler(MovieContext context)
    {
        _context = context;
    }
    public async Task Handle(RemoveSeriesCommand request, CancellationToken cancellationToken)
    {
        var series = await _context.Serieses.FindAsync(request.SeriesId);
        if (series != null)
        {
            _context.Serieses.Remove(series);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
