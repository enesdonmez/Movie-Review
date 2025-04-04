using MediatR;
using MovieReview.Application.Features.Mediator.Queries.TagQueries;
using MovieReview.Application.Features.Mediator.Results.TagResults;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.Mediator.Handlers.TagHandlers
{
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
    {
        private readonly MovieContext _context;
        public GetTagByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.FindAsync(request.TagId);
            return new GetTagByIdQueryResult
            {
                Title = values.Title
            };
        }
    }
}
