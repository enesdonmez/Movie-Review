using MediatR;

namespace MovieReview.Application.Features.Mediator.Commands.TagCommands
{
    public class RemoveTagCommand : IRequest
    {
        public int TagId { get; set; }
        public RemoveTagCommand(int tagId)
        {
            TagId = tagId;
        }
    }
}
