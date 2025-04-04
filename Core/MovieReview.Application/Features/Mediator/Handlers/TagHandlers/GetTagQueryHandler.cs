using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieReview.Application.Features.Mediator.Queries.TagQueries;
using MovieReview.Application.Features.Mediator.Results.TagResults;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.Mediator.Handlers.TagHandlers
{
    public class GetTagQueryHandler : IRequestHandler<GetTagQuery, List<GetTagQueryResult>>
    {
        private readonly MovieContext _context;
        public GetTagQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<GetTagQueryResult>> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.AsNoTracking().ToListAsync();
            return values.Select(x => new GetTagQueryResult
            {
                TagId = x.TagId,
                Title = x.Title
            }).ToList();
        }
    }
}
