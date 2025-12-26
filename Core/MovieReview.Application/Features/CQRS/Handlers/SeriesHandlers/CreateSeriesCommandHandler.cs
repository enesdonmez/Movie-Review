using MovieReview.Application.Features.CQRS.Commands.SeriesCommands;
using MovieReview.Domain.Entities;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.SeriesHandlers;

public class CreateSeriesCommandHandler
{
    private readonly MovieContext _context;

    public CreateSeriesCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(CreateSeriesCommand request, CancellationToken cancellationToken)
    {
        var series = new Series
        {
            Title = request.Title,
            CoverImageUrl = request.CoverImageUrl,
            Rating = request.Rating,
            Description = request.Description,
            FirstAirDate = request.FirstAirDate,
            CreatedYear = request.CreatedYear,
            AverageEpisodeDuration = request.AverageEpisodeDuration,
            SeasonCount = request.SeasonCount,
            EpisodeCount = request.EpisodeCount,
            Status = request.Status,
            CategoryId = request.CategoryId
        };
        _context.Serieses.Add(series);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
