using MediatR;
using MovieReview.Application.Features.Mediator.Queries.CastQueries;
using MovieReview.Application.Features.Mediator.Results.CastResults;
using MovieReview.Persistence.Context;
using System.Reflection.Metadata.Ecma335;

namespace MovieReview.Application.Features.Mediator.Handlers.CastHandlers;

public class GetCastByIdQueryHandler : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>
{
    private readonly MovieContext _context;

    public GetCastByIdQueryHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _context.Casts.FindAsync(request.CastId);
        if (value != null)
        {
            return new GetCastByIdQueryResult
            {
                CastId = value.CastId,
                Title = value.Title,
                Name = value.Name,
                Surname = value.Surname,
                ImageUrl = value.ImageUrl,
                Overview = value.Overview,
                Biography = value.Biography
            };
        }
        
        return new GetCastByIdQueryResult();

    }
}
