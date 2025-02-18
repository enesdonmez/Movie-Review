using MovieReview.Application.Features.CQRS.Queries.CategoryQueries;
using MovieReview.Application.Features.CQRS.Results.CategoryResults;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly MovieContext _movieContext;

        public GetCategoryByIdQueryHandler(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var value = await _movieContext.Categories.FindAsync(query.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryName = value.CategoryName,
                Id = value.Id
            };
        }
    }
}
