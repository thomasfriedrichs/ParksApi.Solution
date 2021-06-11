namespace ParkLocator.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int YearFounded { get; set; }
        public int YearlyVisitors { get; set; }
    }
}