
namespace DataAccessLayer.Models
{
    public class Plane
    {
        public int PlaneId { get; set; }
        public string PlaneName { get; set; } = null!;
        public ICollection<Flight> Flights { get; set; } = null!;
    }
}
