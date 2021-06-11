namespace NationalParksLocator.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int YearFounded { get; set; }
        public string YearlyVisitors { get; set; }
    }
}