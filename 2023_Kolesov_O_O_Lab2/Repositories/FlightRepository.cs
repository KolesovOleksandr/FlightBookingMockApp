using DataAccessLayer.Models;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Repositories.InterfaceRepositories;

namespace DataAccessLayer.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly DbSet<Flight> _flights;

        public FlightRepository(TimetableContext context)
        {
            _flights = context.Flights;
        }

        public void Add(Flight flight)
        {
            _flights.Add(flight);
        }

        public void Delete(Flight flight)
        {
            _flights.Remove(flight);
        }

        public IEnumerable<Flight> GetAll()
        {
            return _flights.ToList();
        }

        public Flight? GetById(int id)
        {
            return _flights.Find(id);
        }

        public void Update(Flight flight)
        {
            _flights.Update(flight);
        }
    }
}
