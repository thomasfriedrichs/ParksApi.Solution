using Microsoft.EntityFrameworkCore;

namespace NationalParksLocator.Models
{
    public class NationalParksLocatorContext : DbContext
    {
        public NationalParksLocatorContext(DbContextOptions<NationalParksLocatorContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                    new Park { ParkId = 1, Name = "Acadia", State = "Maine", YearFounded = 1919, YearlyVisitors = "3,500,000" },
                    new Park { ParkId = 2, Name = "American Samoa", State = "American Samoa", YearFounded = 1988, YearlyVisitors = "60,000" },
                    new Park { ParkId = 3, Name = "Arches", State = "Utah", YearFounded = 1971, YearlyVisitors = "1,600,000" },
                    new Park { ParkId = 4, Name = "Badlands", State = "South Dakota", YearFounded = 1978, YearlyVisitors = "970,000" },
                    new Park { ParkId = 5, Name = "Big Bend", State = "Texas", YearFounded = 1944, YearlyVisitors = "460,000" },
                    new Park { ParkId = 6, Name = "Biscayne", State = "Florida", YearFounded = 1980, YearlyVisitors = "700,000" },
                    new Park { ParkId = 7, Name = "Black Canyon of the Gunnison", State = "Colorado", YearFounded = 1999, YearlyVisitors = "432,000" },
                    new Park { ParkId = 8, Name = "Bryce Canyon", State = "Utah", YearFounded = 1928, YearlyVisitors = "2,500,000" },
                    new Park { ParkId = 9, Name = "Canyonlands", State = "Utah", YearFounded = 1964, YearlyVisitors = "733,000" },
                    new Park { ParkId = 10, Name = "Capitol Reef", State = "Utah", YearFounded = 1930, YearlyVisitors = "1,200,000" },
                    new Park { ParkId = 11, Name = "Carlsbad Caverns", State = "New Mexico", YearFounded = 1930, YearlyVisitors = "440,000" }
                );
        }

        public DbSet<Park> Parks { get; set; }
    }
}