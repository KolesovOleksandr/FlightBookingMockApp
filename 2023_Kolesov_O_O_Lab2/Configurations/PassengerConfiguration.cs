using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccessLayer.Models;

namespace DataAccessLayer.Configurations
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.HasData(
                new Passenger { PassengerId = 1, FirstName = "John", LastName  = "Black" },
                new Passenger { PassengerId = 2, FirstName = "Aron", LastName  = "Smith" },
                new Passenger { PassengerId = 3, FirstName = "Taras", LastName  = "Clarc" },
                new Passenger { PassengerId = 4, FirstName = "Brian", LastName  = "Lester" },
                new Passenger { PassengerId = 5, FirstName = "Krieg", LastName  = "Allice" }
                );
        } 
    }
}
