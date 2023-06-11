using DataAccessLayer.Models; 

namespace DataAccessLayer.DTOs
{
    public class FlightDTO
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; } = null!;
        public int DeparturePointId { get; set; }
        public int DestinationPointId { get; set; }
        public int PlaneId { get; set; }
        public FlightDTO(){}
        public FlightDTO(Flight? flight)
        {
            if (flight == null)
            {
                throw new ArgumentNullException(nameof(flight));
            }
            FlightId = flight.FlightId;
            FlightNumber = flight.FlightNumber;
            DeparturePointId = flight.DeparturePointId;
            DestinationPointId = flight.DestinationPointId;
            PlaneId = flight.PlaneId;
        }
    }
}
