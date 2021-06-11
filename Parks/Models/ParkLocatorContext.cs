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
                  new Park { ParkId = 1, Name = "Acadia", State = "Maine", YearFounded = 1919, YearlyVisitors = "3437286" },
                  new Park { ParkId = 2, Name = "American Samoa", State = "American Samoa", YearFounded = 1988, YearlyVisitors = "60000" },
                  new Park { ParkId = 3, Name = "Arches", State = "Utah", YearFounded = 1971, YearlyVisitors = "1659702" },
                  new Park { ParkId = 4, Name = "Pip", State = "Shark", YearFounded = 4, YearlyVisitors = "Male" },
                  new Park { ParkId = 5, Name = "Bartholomew", State = "Dinosaur", YearFounded = 22, YearlyVisitors = "Male" }
              );
        }

        public DbSet<Park> Parks { get; set; }
    }
}