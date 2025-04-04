using MediatR;
using MovieReview.Application.Features.Mediator.Results.CastResults;

namespace MovieReview.Application.Features.Mediator.Queries.CastQueries
{
    public class GetCastQuery : IRequest<List<GetCastQueryResult>>
    {
    }
}
