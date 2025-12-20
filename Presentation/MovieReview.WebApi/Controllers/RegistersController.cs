using Microsoft.AspNetCore.Mvc;
using MovieReview.Application.Features.CQRS.Commands.UserRegisterCommands;
using MovieReview.Application.Features.CQRS.Handlers.UserRegisterHandlers;

namespace MovieReview.WebApi.Controllers
{
    [Route("api/register")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly CreateUserRegisterCommandHandler _createUserRegisterCommandHandler;

        public RegistersController(CreateUserRegisterCommandHandler createUserRegisterCommandHandler)
        {
            _createUserRegisterCommandHandler = createUserRegisterCommandHandler;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] CreateUserRegisterCommand command)
        {
            if (command == null)
            {
                return BadRequest("Bilgileri kontrol ediniz.");
            }
            await _createUserRegisterCommandHandler.Handle(command);
            return Ok("Kullanıcı başarıyla eklendi.");

        }
    }
}
