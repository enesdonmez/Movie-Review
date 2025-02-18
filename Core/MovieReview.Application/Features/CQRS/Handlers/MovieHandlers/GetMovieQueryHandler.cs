using Microsoft.EntityFrameworkCore;
using MovieReview.Application.Features.CQRS.Results.CategoryResults;
using MovieReview.Application.Features.CQRS.Results.MovieResults;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler
    {
        private readonly MovieContext _context;

        public GetMovieQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetMovieQueryResult>> Handle()
        {
            var values = await _context.Movies.AsNoTracking().ToListAsync();

            return values.Select(c => new GetMovieQueryResult
            {
                MovieId = c.MovieId,
                CoverImageUrl = c.CoverImageUrl,
                Description = c.Description,
                CreatedYear = c.CreatedYear,
                Status = c.Status,
                Duration = c.Duration,
                Rating = c.Rating,
                Title = c.Title,
                ReleaseDate = c.ReleaseDate

            }).ToList();
        }
    }
}
