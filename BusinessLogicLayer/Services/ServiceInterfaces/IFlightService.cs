using DataAccessLayer.DTOs;

namespace BusinessLogicLayer.Services.ServiceInterfaces
{
    public interface IFlightService
    {
        FlightDTO? GetFlightByNumber(string number);
    }
}
