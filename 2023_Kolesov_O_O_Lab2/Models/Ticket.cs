
namespace DataAccessLayer.Models
{
    public class Ticket
    {
        public int TicketId { get; set; } 
        public string TicketNumber { get; set; } = null!;
        public double TicketPrice { get; set; }
        public int SeatNumber { get; set; }
        public DateTime AquirementTime { get; set; }
        public DateTime? ReturnmentTime { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; } = null!;
        public int FlightId { get; set; }
        public Flight Flight { get; set; } = null!;
    }
}
