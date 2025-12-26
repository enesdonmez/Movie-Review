using MovieReview.Application.Features.CQRS.Queries.MovieQueries;
using MovieReview.Application.Features.CQRS.Results.SeriesResults;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.SeriesHandlers;

public class GetSeriesByIdQueryHandler
{
    private readonly MovieContext _context;

    public GetSeriesByIdQueryHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task<GetSeriesByIdQueryResult> Handle(GetMovieByIdQuery query)
    {
        var series = await _context.Serieses.FindAsync(query.MovieId);
        return new GetSeriesByIdQueryResult
        {
            SeriesId = series.SeriesId,
            Title = series.Title,
            CoverImageUrl = series.CoverImageUrl,
            Rating = series.Rating,
            Description = series.Description,
            FirstAirDate = series.FirstAirDate,
            CreatedYear = series.CreatedYear,
            AverageEpisodeDuration = series.AverageEpisodeDuration,
            SeasonCount = series.SeasonCount,
            EpisodeCount = series.EpisodeCount,
            Status = series.Status,
            CategoryId = series.CategoryId
        };
    }
}
