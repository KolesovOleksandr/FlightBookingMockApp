
namespace DataAccessLayer.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; } = null!;
        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public ICollection<Flight> DeparturePoints { get; set; } = null!;
        public ICollection<Flight> DestinationPoints { get; set; } = null!;
    }
}
