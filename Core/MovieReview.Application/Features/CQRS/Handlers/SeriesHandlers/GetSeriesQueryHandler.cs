using Microsoft.EntityFrameworkCore;
using MovieReview.Application.Features.CQRS.Results.SeriesResults;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.SeriesHandlers
{
    public class GetSeriesQueryHandler
    {
        private readonly MovieContext _context;

        public GetSeriesQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetSeriesQueryResult>> Handle()
        {
            var series = await _context.Serieses.ToListAsync();
            return series.Select(s => new GetSeriesQueryResult
            {
                SeriesId = s.SeriesId,
                Title = s.Title,
                CoverImageUrl = s.CoverImageUrl,
                Rating = s.Rating,
                Description = s.Description,
                FirstAirDate = s.FirstAirDate,
                CreatedYear = s.CreatedYear,
                AverageEpisodeDuration = s.AverageEpisodeDuration,
                SeasonCount = s.SeasonCount,
                EpisodeCount = s.EpisodeCount,
                Status = s.Status,
                CategoryId = s.CategoryId
            }).ToList();
        }
    }
}
