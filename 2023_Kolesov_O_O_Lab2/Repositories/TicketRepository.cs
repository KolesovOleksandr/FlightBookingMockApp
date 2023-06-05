using DataAccessLayer.Models;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Repositories.InterfaceRepositories;

namespace DataAccessLayer.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly DbSet<Ticket> _tickets;

        public TicketRepository(TimetableContext context)
        {
            _tickets = context.Tickets;
        }

        public void Add(Ticket ticket)
        {
            _tickets.Add(ticket);
        }

        public void Delete(Ticket ticket)
        {
            _tickets.Remove(ticket);
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _tickets.ToList();
        }

        public Ticket? GetById(int id)
        {
            return _tickets.Find(id);
        }

        public void Update(Ticket ticket)
        {
            _tickets.Update(ticket);
        }
    }
}
