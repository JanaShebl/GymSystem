using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GymSystem.Configurations
{
    public class PlanConfig : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(x => x.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("duration_Constraint", "DurationInMonths  >= 1 and DurationInMonths  <= 365");
            });
        }
    }
}
