using Microsoft.AspNetCore.Identity;
using MovieReview.Application.Features.CQRS.Commands.UserRegisterCommands;
using MovieReview.Persistence.Context;
using MovieReview.Persistence.Identity;

namespace MovieReview.Application.Features.CQRS.Handlers.UserRegisterHandlers;

public class CreateUserRegisterCommandHandler
{
    private readonly MovieContext _context;
    private readonly UserManager<AppUser> _userManager;

    public CreateUserRegisterCommandHandler(MovieContext context, UserManager<AppUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task Handle(CreateUserRegisterCommand command)
    {
        var user = new AppUser
        {
            Name = command.Name,
            SurName = command.Surname,
            UserName = command.Username,
            Email = command.Email,
        };
        await _userManager.CreateAsync(user, command.Password);
    }
}

