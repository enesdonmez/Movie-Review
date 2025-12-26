using MovieReview.Application.Features.CQRS.Commands.SeriesCommands;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.SeriesHandlers;

public class UpdateSeriesCommandHandler
{
    private readonly MovieContext _context;

    public UpdateSeriesCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateSeriesCommand request, CancellationToken cancellationToken)
    {
        var series = await _context.Serieses.FindAsync(request.SeriesId);
        if (series != null)
        {
            series.Title = request.Title;
            series.CoverImageUrl = request.CoverImageUrl;
            series.Rating = request.Rating;
            series.Description = request.Description;
            series.FirstAirDate = request.FirstAirDate;
            series.CreatedYear = request.CreatedYear;
            series.AverageEpisodeDuration = request.AverageEpisodeDuration;
            series.SeasonCount = request.SeasonCount;
            series.EpisodeCount = request.EpisodeCount;
            series.Status = request.Status;
            series.CategoryId = request.CategoryId;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
