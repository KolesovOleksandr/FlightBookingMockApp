using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccessLayer.Models;

namespace DataAccessLayer.Configurations
{
    public class PlaneConfiguration : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.HasData(
                new Plane { PlaneId = 1, PlaneName  = "Airbus" },
                new Plane { PlaneId = 2, PlaneName  = "Boeing" },
                new Plane { PlaneId = 3, PlaneName  = "McDonnel" }
                );
        }
    }
}
