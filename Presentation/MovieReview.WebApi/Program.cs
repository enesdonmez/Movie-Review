using MovieReview.Application.Features.CQRS.Handlers.CategoryHandlers;
using MovieReview.Application.Features.CQRS.Handlers.MovieHandlers;
using MovieReview.Persistence.Context;
using Scalar.AspNetCore;
using System.Reflection;

namespace MovieReview.WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<MovieContext>();

        builder.Services.AddScoped<GetCategoryQueryHandler>();
        builder.Services.AddScoped<CreateCategoryCommandHandler>();
        builder.Services.AddScoped<UpdateCategoryCommandHandler>();
        builder.Services.AddScoped<RemoveCategoryCommandHandler>();
        builder.Services.AddScoped<GetCategoryByIdQueryHandler>();

        builder.Services.AddScoped<GetMovieQueryHandler>();
        builder.Services.AddScoped<CreateMovieCommandHandler>();
        builder.Services.AddScoped<UpdateMovieCommandHandler>();
        builder.Services.AddScoped<RemoveMovieCommandHandler>();
        builder.Services.AddScoped<GetMovieByIdQueryHandler>();

        builder.Services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        builder.Services.AddControllers();
        builder.Services.AddOpenApi();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
           app.MapScalarApiReference(sc =>
           {
               sc.Theme = ScalarTheme.Kepler;
               sc.WithTitle("Movie Review API");
               

           });
        }

        app.UseHttpsRedirection();
       
        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
