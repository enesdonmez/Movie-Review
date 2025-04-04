using MediatR;

namespace MovieReview.Application.Features.Mediator.Commands.TagCommands
{
    public class CreateTagCommand :IRequest
    {
        public string Title { get; set; }
    }
}
