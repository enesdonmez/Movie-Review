using MediatR;
using MovieReview.Application.Features.Mediator.Results.CastResults;

namespace MovieReview.Application.Features.Mediator.Queries.CastQueries
{
    public class GetCastByIdQuery : IRequest<GetCastByIdQueryResult>
    {
        public int CastId { get; set; }

        public GetCastByIdQuery(int castId)
        {
            CastId = castId;
        }
    }
}
