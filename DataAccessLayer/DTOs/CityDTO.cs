using DataAccessLayer.Models;

namespace DataAccessLayer.DTOs
{
    public class CityDTO
    {
        public int CityId { get; set; }
        public string CityName { get; set; } = null!;
        public CityDTO(){}
        public CityDTO(City city)
        {
            CityId = city.CityId;
            CityName = city.CityName;
        }
    }
}
