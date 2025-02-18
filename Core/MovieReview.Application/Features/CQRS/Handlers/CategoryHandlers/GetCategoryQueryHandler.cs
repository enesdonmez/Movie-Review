using Microsoft.EntityFrameworkCore;
using MovieReview.Application.Features.CQRS.Results.CategoryResults;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly MovieContext _context;

        public GetCategoryQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _context.Categories.AsNoTracking().ToListAsync();

            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryName = x.CategoryName,
                Id = x.Id
            }).ToList();
        }
    }
}
