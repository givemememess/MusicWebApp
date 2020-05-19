using Microsoft.EntityFrameworkCore;
using MusicWebApplication.Models.MusicModel;

namespace MusicWebApplication.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Producer> Producers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base (options) { }
    }
}
