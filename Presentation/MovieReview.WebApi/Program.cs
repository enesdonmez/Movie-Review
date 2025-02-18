
using Scalar.AspNetCore;

namespace MovieReview.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


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
}
