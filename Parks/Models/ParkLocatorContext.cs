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
                  new Park { ParkId = 1, Name = "Acadia", State = "Maine", YearFounded = 1919, YearlyVisitors = "3500000" },
                  new Park { ParkId = 2, Name = "American Samoa", State = "American Samoa", YearFounded = 1988, YearlyVisitors = "60000" },
                  new Park { ParkId = 3, Name = "Arches", State = "Utah", YearFounded = 1971, YearlyVisitors = "1600000" },
                  new Park { ParkId = 4, Name = "Badlands", State = "South Dakota", YearFounded = 1978, YearlyVisitors = "970000" },
                  new Park { ParkId = 5, Name = "Big Bend", State = "Texas", YearFounded = 1944, YearlyVisitors = "460000" }
              );
        }

        public DbSet<Park> Parks { get; set; }
    }
}