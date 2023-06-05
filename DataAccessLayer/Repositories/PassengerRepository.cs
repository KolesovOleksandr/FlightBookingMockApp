using DataAccessLayer.Models;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Repositories.InterfaceRepositories;

namespace DataAccessLayer.Repositories
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly DbSet<Passenger> _passengers;

        public PassengerRepository(TimetableContext context)
        {
            _passengers = context.Set<Passenger>();
        }

        public void Add(Passenger passenger)
        {
            _passengers.Add(passenger);
        }

        public void Delete(Passenger passenger)
        {
            _passengers.Remove(passenger);
        }

        public IEnumerable<Passenger> GetAll()
        {
            return _passengers.ToList();
        }

        public Passenger? GetById(int id)
        {
            return _passengers.Find(id);
        }

        public void Update(Passenger passenger)
        {
            _passengers.Update(passenger);
        }
    }
}
