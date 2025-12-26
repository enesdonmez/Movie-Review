using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieReview.Domain.Entities;
using MovieReview.Persistence.Identity;

namespace MovieReview.Persistence.Context;

public class MovieContext : IdentityDbContext<AppUser>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-VNTHV06;initial Catalog=MovieReviewDb;integrated Security=true;TrustServerCertificate=true;");
    }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Cast> Casts { get; set; }
    public DbSet<Series> Serieses { get; set; }
}
