using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasData(
                new Flight
                {
                    FlightId = 1, 
                    FlightNumber = "qwerty-12345",
                    PlaneId = 1,
                    DeparturePointId = 1,
                    DestinationPointId  = 2
                },
                new Flight
                {
                    FlightId = 2,
                    FlightNumber = "qwerty-12424",
                    PlaneId = 2,
                    DeparturePointId  = 2,
                    DestinationPointId  = 3
                },
                new Flight
                {
                    FlightId = 3,
                    FlightNumber = "qwerty-12347",
                    PlaneId = 3,
                    DeparturePointId  = 3,
                    DestinationPointId  = 4
                },
                new Flight
                {
                    FlightId = 4,
                    FlightNumber = "qwerty-12341",
                    PlaneId = 1,
                    DeparturePointId  = 4,
                    DestinationPointId  = 5
                },
                new Flight
                {
                    FlightId = 5,
                    FlightNumber = "qwerty-12340",
                    PlaneId = 2,
                    DeparturePointId  = 5,
                    DestinationPointId  = 1
                }
                );
        }
    }
}
