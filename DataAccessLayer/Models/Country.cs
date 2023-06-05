
namespace DataAccessLayer.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;
        public ICollection<City> Cities { get; set; } = null!;
    }
}
