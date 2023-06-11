using DataAccessLayer.Models;

namespace DataAccessLayer.DTOs
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public DateTime? ReturnmentTime { get; set; }
        public int DocumentId { get; set; }
        public int FlightId { get; set; }
        public string? Number { get; set; }
        public double Price { get; set; }
        public int? SeatNumber { get; set; }
        public TicketDTO(){}
        public TicketDTO(Ticket ticket)
        {
            Id = ticket.TicketId;
            ReturnmentTime = ticket.ReturnmentTime;
            DocumentId = ticket.DocumentId;
            FlightId = ticket.FlightId;
            Number = ticket.TicketNumber;
            Price = ticket.TicketPrice;
            SeatNumber = ticket.SeatNumber;
        }
    }
}
