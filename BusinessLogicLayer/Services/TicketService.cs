using DataAccessLayer.Repositories.InterfaceRepositories;
using BusinessLogicLayer.Services.ServiceInterfaces;
using DataAccessLayer.DTOs;

namespace BusinessLogicLayer.Services
{
    public class TicketService
    {
        readonly ITicketRepository _ticketRepository;
        readonly IFlightService _flightService;
        readonly IDocumentService _documentService;

        public TicketService(ITicketRepository ticketRepository,
            IFlightService flightService, IDocumentService documentService)
        {
            _ticketRepository = ticketRepository;
            _flightService = flightService;
            _documentService = documentService;
        }

        public bool BookTicket(string flightNumber, long documentNumber)
        {
            DocumentDTO? correspDocument = _documentService.GetDocumentByNumber(documentNumber);
            FlightDTO? correspFlight = _flightService.GetFlightByNumber(flightNumber);
            if (correspFlight == null || correspDocument == null) 
            {
                return false;
            }
            var ticketToAdd = new TicketDTO()
            {
                Id = _ticketRepository.GetAll().Count() + 1,
                DocumentId = correspDocument.DocumentId,
                FlightId = correspFlight.FlightId
            };
            _ticketRepository.Add(ticketToAdd);
            return true;
        }

        public List<TicketDTO> GetAllTicketsByDocumentNumber(long number) 
        {
            List<TicketDTO> tickets = new();
            tickets = _ticketRepository.GetAll()
                .Where(x => x.DocumentId == _documentService.GetDocumentByNumber(number)?.DocumentId)
                .ToList();
            return tickets;
        }

    }
}
