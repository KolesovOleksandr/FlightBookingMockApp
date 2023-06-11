using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; } = null!;
        public int DeparturePointId { get; set; }
        public City DeparturePoint { get; set; } = null!;
        public int DestinationPointId { get; set; }
        public City DestinationPoint { get; set; } = null!;
        public int PlaneId { get; set; }
        public Plane Plane { get; set; } = null!;
        public ICollection<Ticket> Tickets { get; set; } = null!;
    }
}
