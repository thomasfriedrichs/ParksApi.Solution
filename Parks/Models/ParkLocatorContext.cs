using Microsoft.EntityFrameworkCore;

namespace ParkLocator.Models
{
    public class ParkLocatorContext : DbContext
    {
        public ParkLocatorContext(DbContextOptions<ParkLocatorContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
              .HasData(
                  new Park { ParkId = 1, Name = "Matilda", State = "Woolly Mammoth", YearFounded = 7, Rating = "Female" },
                  new Park { ParkId = 2, Name = "Rexie", State = "Dinosaur", YearFounded = 10, Rating = "Female" },
                  new Park { ParkId = 3, Name = "Matilda", State = "Dinosaur", YearFounded = 2, Rating = "Female" },
                  new Park { ParkId = 4, Name = "Pip", State = "Shark", YearFounded = 4, Rating = "Male" },
                  new Park { ParkId = 5, Name = "Bartholomew", State = "Dinosaur", YearFounded = 22, Rating = "Male" }
              );
        }

        public DbSet<Park> Parks { get; set; }
    }
}