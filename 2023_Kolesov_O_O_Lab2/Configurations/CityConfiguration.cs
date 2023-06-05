using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccessLayer.Models;

namespace DataAccessLayer.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City { CityId = 1, CityName = "Vinnytsia", CountryId = 1 },
                new City { CityId = 2, CityName = "Kyiv", CountryId= 1 },
                new City { CityId = 3, CityName = "Krakiv", CountryId = 2 },
                new City { CityId = 4, CityName = "Warshawa", CountryId = 2 },
                new City { CityId = 5, CityName = "Berlin", CountryId = 3 },
                new City { CityId = 6, CityName = "Hamburg", CountryId = 3 },
                new City { CityId = 7, CityName = "Paris", CountryId = 4 },
                new City { CityId = 8, CityName = "Bordo", CountryId = 4 },
                new City { CityId = 9, CityName = "London", CountryId = 5 },
                new City { CityId = 10, CityName = "Liverpool", CountryId = 5 }
                );
        }
    }
}
