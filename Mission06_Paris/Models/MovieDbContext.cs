using Microsoft.EntityFrameworkCore;

namespace Mission06_Paris.Models // Ensure the namespace matches your project structure
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}