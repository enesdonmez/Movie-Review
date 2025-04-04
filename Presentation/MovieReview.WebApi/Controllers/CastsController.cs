using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieReview.Application.Features.Mediator.Commands.CastCommands;
using MovieReview.Application.Features.Mediator.Queries.CastQueries;

namespace MovieReview.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CastsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCastList")]
        public async Task<IActionResult> GetCastList()
        {
            var result = await _mediator.Send(new GetCastQuery());
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("CreateCast")]
        public async Task<IActionResult> CreateCast([FromBody] CreateCastCommand command)
        {
            await _mediator.Send(command);

            return Ok("Ekleme Başarılı");
        }

        [HttpDelete("DeleteCast")]
        public async Task<IActionResult> DeleteCast(int id)
        {
            var command = new RemoveCastCommand(id);
            await _mediator.Send(command);
            return Ok("Silme Başarılı");
        }

        [HttpGet("GetCastById")]
        public async Task<IActionResult> GetCastById(int id)
        {
            var result = await _mediator.Send(new GetCastByIdQuery(id));
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("UpdateCast")]
        public async Task<IActionResult> UpdateCast(UpdateCastCommand command)
        {
            await _mediator.Send(command);

            return Ok("güncelleme başarılı");
        }
    }
}
