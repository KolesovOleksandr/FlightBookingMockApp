using DataAccessLayer.Models;
using DataAccessLayer.DTOs;
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

        public void Add(TicketDTO ticketDTO)
        {
            Ticket ticket = new()
            {
                TicketId = ticketDTO.Id,
                TicketNumber = new Guid().ToString(),
                TicketPrice = new Random().Next(100, 1000),
                SeatNumber = new Random().Next(1, 50),
                AquirementTime = DateTime.Now,
                DocumentId = ticketDTO.DocumentId,
                FlightId = ticketDTO.FlightId
            };
            _tickets.Add(ticket);
        }

        public void Delete(TicketDTO ticketDTO)
        {
            var ticket = _tickets.FirstOrDefault(x => x.TicketId == ticketDTO.Id);
            if (ticket != null)
            {
                _tickets.Remove(ticket);
            }
        }

        public IEnumerable<TicketDTO> GetAll()
        {
            List<TicketDTO> result = new();
            foreach (var ticket in _tickets)
            {
                result.Add(new TicketDTO()
                {
                    Id = ticket.TicketId, 
                    ReturnmentTime = ticket.ReturnmentTime, 
                    DocumentId = ticket.DocumentId, 
                    FlightId = ticket.FlightId,
                    Number = ticket.TicketNumber,
                    Price = ticket.TicketPrice,

                });
            }
            return result;
        }

        public TicketDTO? GetById(int id)
        {
            var ticket = _tickets.Find(id);
            if (ticket != null)
            {
                return new TicketDTO(ticket);
            }
            return null;
        }

        public void Update(TicketDTO ticketDTO)
        {
            Ticket ticket = new()
            {
                TicketId = ticketDTO.Id,
                TicketNumber = ticketDTO.Number,
                TicketPrice = new Random().Next(100, 1000),
                SeatNumber = new Random().Next(1, 50),
                AquirementTime = DateTime.Now,
                DocumentId = ticketDTO.DocumentId,
                FlightId = ticketDTO.FlightId,
                ReturnmentTime = ticketDTO.ReturnmentTime
            };
            _tickets.Update(ticket);
        }
    }
}