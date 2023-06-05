using DataAccessLayer.Configurations;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    public class TimetableContext:DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\C#\\2023_Kolesov_O_O_Lab2\\TimetableDB\\Timetable.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>()
                .HasOne(f => f.DeparturePoint)
                .WithMany(c => c.DeparturePoints)
                .HasForeignKey(f => f.DeparturePointId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Flight>()
                .HasOne(f => f.DestinationPoint)
                .WithMany(c => c.DestinationPoints)
                .HasForeignKey(f => f.DestinationPointId)
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CountryConfiguration())
                .ApplyConfiguration(new CityConfiguration())
                .ApplyConfiguration(new PlaneConfiguration())
                .ApplyConfiguration(new PassengerConfiguration())
                .ApplyConfiguration(new DocumentConfiguration())
                .ApplyConfiguration(new TicketConfiguration())
                .ApplyConfiguration(new FlightConfiguration());
        }

    }
}
