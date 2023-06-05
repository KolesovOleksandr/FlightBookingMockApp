using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.InterfaceRepositories;
using System.Net.Sockets;

namespace BusinessLogicLayer.Services
{
    public class TicketBookingService
    {
        readonly ITicketRepository _ticketRepository;
        readonly IDocumentRepository _documentRepository;
        readonly IFlightRepository _flightRepository;

        public TicketBookingService(ITicketRepository ticketRepository, 
            IDocumentRepository documentRepository,
            IFlightRepository flightRepository)
        {
            _ticketRepository = ticketRepository;
            _documentRepository = documentRepository;
            _flightRepository = flightRepository;
        }

        public bool BookTicket(int flightId, long documentNumber) 
        {
            if (_documentRepository.GetDocumentByNumber(documentNumber) == null || _flightRepository.GetById(flightId) == null)
            {
                return false;
            }
            return true;
        }

    }
}
