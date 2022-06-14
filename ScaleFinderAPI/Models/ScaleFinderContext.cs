using Microsoft.EntityFrameworkCore;

namespace ScaleFinderAPI.Models
{
    public class ScaleFinderContext : DbContext
    {
        public ScaleFinderContext(DbContextOptions<ScaleFinderContext> options) : base(options)
        {

        }

        public DbSet<Scale> ScaleItems { get; set; } = null!;
    }
}
