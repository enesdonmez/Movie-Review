using MovieReview.Application.Features.CQRS.Queries.MovieQueries;
using MovieReview.Application.Features.CQRS.Results.MovieResults;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler
    {
        private readonly MovieContext _context;

        public GetMovieByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetMovieByIdQueryResult> Handle(GetMovieByIdQuery query)
        {
            var value = await _context.Movies.FindAsync(query.MovieId);

            return new GetMovieByIdQueryResult
            {
                Title = value.Title,
                Description = value.Description,
                CoverImageUrl = value.CoverImageUrl,
                ReleaseDate = value.ReleaseDate,
                Status = value.Status,
                Rating = value.Rating,
                CreatedYear = value.CreatedYear,
                Duration = value.Duration,
            };
        }
    }
}
