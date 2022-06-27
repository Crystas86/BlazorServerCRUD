using Microsoft.EntityFrameworkCore;

namespace BlazorServerCRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    Name = "World of Warcraft",
                    Developer = "Blizzard",
                    Release = new DateTime(2004, 11, 01)
                },
                new Game
                {
                    Id = 2,
                    Name = "Final Fantasy 7 Remake",
                    Developer = "Square Enix",
                    Release = new DateTime(2022, 6, 21)
                }
                );
        }

        public DbSet<Game> Games => Set<Game>();
    }
}
