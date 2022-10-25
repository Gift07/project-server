using Microsoft.EntityFrameworkCore;
using server.Models;


namespace server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<MoviesModel> Movies { get; set; }
        public DbSet<Image> Image { get; set; }

        public DbSet<Actor> Actor { get; set; }

    }
}