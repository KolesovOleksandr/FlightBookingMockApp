using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccessLayer.Models;

namespace DataAccessLayer.Configurations
{
    public class CountryConfiguration: IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country { CountryId = 1, CountryName = "Ukraine" },
                new Country { CountryId = 2, CountryName = "Poland"},
                new Country { CountryId = 3, CountryName = "Germany"},
                new Country { CountryId = 4, CountryName = "France"},
                new Country { CountryId = 5, CountryName = "UK"}
                );
        }
    }
}
