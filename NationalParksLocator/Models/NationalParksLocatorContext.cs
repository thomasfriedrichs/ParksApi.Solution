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
                    new Park { ParkId = 11, Name = "Channel Islands", State = "California", YearFounded = 1980, YearlyVisitors = "409,000" },
                    new Park { ParkId = 12, Name = "Conagree", State = "South Carolina", YearFounded = 2003, YearlyVisitors = "159,000" },
                    new Park { ParkId = 13, Name = "Crater Lake", State = "Oregon", YearFounded = 1902, YearlyVisitors = "704,000" },
                    new Park { ParkId = 14, Name = "Cuyahoga Valley", State = "Ohio", YearFounded = 2000, YearlyVisitors = "2,237,000" },
                    new Park { ParkId = 15, Name = "Death Valley", State = "California", YearFounded = 1994, YearlyVisitors = "1,740,000" },
                    new Park { ParkId = 16, Name = "Denali", State = "Alaska", YearFounded = 1917, YearlyVisitors = "4,740,000" },
                    new Park { ParkId = 17, Name = "Dry Tortugas", State = "Florida", YearFounded = 1992, YearlyVisitors = "79,000" },
                    new Park { ParkId = 18, Name = "Everglades", State = "Florida", YearFounded = 1934, YearlyVisitors = "1,500,000" },
                    new Park { ParkId = 19, Name = "Gates of the Arctic", State = "Alaska", YearFounded = 1980, YearlyVisitors = "10,000" },
                    new Park { ParkId = 20, Name = "Gateway Arch", State = "Missouri", YearFounded = 2018, YearlyVisitors = "2,055,000" },
                    new Park { ParkId = 21, Name = "Glacier", State = "Montana", YearFounded = 1910, YearlyVisitors = "3,000,000" },
                    new Park { ParkId = 22, Name = "Glacier Bay", State = "Alaska", YearFounded = 1980, YearlyVisitors = "672,000" },
                    new Park { ParkId = 23, Name = "Grand Canyon", State = "Arizona", YearFounded = 1919, YearlyVisitors = "5,974,000" },
                    new Park { ParkId = 24, Name = "Grand Teton", State = "Wyoming", YearFounded = 1929, YearlyVisitors = "3,400,000" },
                    new Park { ParkId = 25, Name = "Great Basin", State = "Nevada", YearFounded = 1986, YearlyVisitors = "131,000" }
                );
        }

        public DbSet<Park> Parks { get; set; }
    }
}