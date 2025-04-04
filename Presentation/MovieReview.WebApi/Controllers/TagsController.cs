using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieReview.Application.Features.Mediator.Commands.TagCommands;
using MovieReview.Application.Features.Mediator.Queries.TagQueries;

namespace MovieReview.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllTags")]
        public async Task<IActionResult> GetAllTags()
        {
            var result = await _mediator.Send(new GetTagQuery());
            return Ok(result);
        }

        [HttpPost("CreateTag")]
        public async Task<IActionResult> CreateTag([FromBody] CreateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete("RemoveTag")]
        public async Task<IActionResult> RemoveTag(RemoveTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Silme Başarılı");
        }

        [HttpPut("UpdateTag")]
        public async Task<IActionResult> UpdateTag(UpdateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Güncelleme Başarılı");
        }
    }
}
