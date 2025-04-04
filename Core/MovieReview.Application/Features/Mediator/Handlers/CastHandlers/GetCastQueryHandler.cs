using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieReview.Application.Features.Mediator.Queries.CastQueries;
using MovieReview.Application.Features.Mediator.Results.CastResults;
using MovieReview.Persistence.Context;

namespace MovieReview.Application.Features.Mediator.Handlers.CastHandlers;

public class GetCastQueryHandler : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
{
    private readonly MovieContext _context;

    public GetCastQueryHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
    {
        var casts = await _context.Casts.AsNoTracking().ToListAsync(cancellationToken);

        return casts.Select(cast => new GetCastQueryResult
        {
            CastId = cast.CastId,
            Title = cast.Title,
            Name = cast.Name,
            Surname = cast.Surname,
            ImageUrl = cast.ImageUrl,
            Overview = cast.Overview,
            Biography = cast.Biography

        }).ToList();

    }
}
