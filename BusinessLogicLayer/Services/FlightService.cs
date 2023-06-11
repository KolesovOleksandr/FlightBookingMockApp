using DataAccessLayer.Repositories.InterfaceRepositories;
using DataAccessLayer.DTOs;
using BusinessLogicLayer.Services.ServiceInterfaces;

namespace BusinessLogicLayer.Services
{
    public class FlightService : IFlightService
    {
        readonly IFlightRepository _flightRepository;
        readonly ICityRepository _cityRepository;
        
        public FlightService(IFlightRepository flightRepository, ICityRepository cityRepository)
        {
            _flightRepository = flightRepository;
            _cityRepository = cityRepository;
        }
        public FlightDTO? GetFlightByNumber(string number) 
        {
            FlightDTO correspFlight = new();
            try
            {
                correspFlight = new FlightDTO(_flightRepository.GetAll()
                    .FirstOrDefault(x => x.FlightNumber == number));
            }
            catch (ArgumentNullException)
            {
                return null;
            }
            return correspFlight;
        }
        public List<FlightDTO> FlightInfoService(string? DepartureCity, string? DestinationCity)
        {
            List<FlightDTO> suitableFlights = new();
            suitableFlights=_flightRepository.GetAll().Select(e=>new FlightDTO(e))
                .Where(f => f.DeparturePointId == _cityRepository.GetAll()
                .FirstOrDefault(x => x.CityName == DepartureCity)?.CityId &&
                f.DestinationPointId == _cityRepository.GetAll()
                .FirstOrDefault(x => x.CityName == DestinationCity)?.CityId).ToList();
            return suitableFlights;
        }
    }
}
