using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccessLayer.Models;

namespace DataAccessLayer.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasData(
                new Ticket 
                { 
                    TicketId = 1, 
                    TicketNumber = "12345-asd", 
                    TicketPrice = 100, 
                    SeatNumber = 10, 
                    AquirementTime = DateTime.Now, 
                    ReturnmentTime = new DateTime(2022, 12, 31, 23, 59, 59),
                    DocumentId = 1,
                    FlightId = 1
                },
                new Ticket
                {
                    TicketId = 2,
                    TicketNumber = "12345-kjsd",
                    TicketPrice = 101,
                    SeatNumber = 11,
                    AquirementTime = DateTime.Now,
                    ReturnmentTime = new DateTime(2022, 12, 31, 23, 59, 59),
                    DocumentId = 2,
                    FlightId = 2
                },
                new Ticket
                {
                    TicketId = 3,
                    TicketNumber = "12345-uio",
                    TicketPrice = 102,
                    SeatNumber = 12,
                    AquirementTime = DateTime.Now,
                    ReturnmentTime = new DateTime(2022, 12, 31, 23, 59, 59),
                    DocumentId = 3,
                    FlightId = 3
                },
                new Ticket
                {
                    TicketId = 4,
                    TicketNumber = "123456-rewq",
                    TicketPrice = 101,
                    SeatNumber = 13,
                    AquirementTime = DateTime.Now,
                    ReturnmentTime = new DateTime(2022, 12, 31, 23, 59, 59),
                    DocumentId = 4,
                    FlightId = 4
                },
                new Ticket
                {
                    TicketId = 5,
                    TicketNumber = "12345-qwerty",
                    TicketPrice = 101,
                    SeatNumber = 7,
                    AquirementTime = DateTime.Now,
                    ReturnmentTime = new DateTime(2022, 12, 31, 23, 59, 59),
                    DocumentId = 5,
                    FlightId = 5
                }
                );
        }
    }
}
