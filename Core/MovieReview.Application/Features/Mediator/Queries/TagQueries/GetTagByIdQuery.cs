using MediatR;
using MovieReview.Application.Features.Mediator.Results.TagResults;

namespace MovieReview.Application.Features.Mediator.Queries.TagQueries
{
    public class GetTagByIdQuery : IRequest<GetTagByIdQueryResult>
    {
        public int TagId { get; set; }

        public GetTagByIdQuery(int tagId)
        {
            TagId = tagId;
        }
    }
}
