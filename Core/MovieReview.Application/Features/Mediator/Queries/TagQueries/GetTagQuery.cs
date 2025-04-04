using MediatR;
using MovieReview.Application.Features.Mediator.Results.TagResults;

namespace MovieReview.Application.Features.Mediator.Queries.TagQueries
{
    public class GetTagQuery : IRequest<List<GetTagQueryResult>>
    {
    }
}
