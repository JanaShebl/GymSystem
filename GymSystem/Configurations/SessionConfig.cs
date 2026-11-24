using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GymSystem.Configurations
{
    public class SessionConfig : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x=>x.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder.HasOne(x => x.Trainer)
                .WithMany(x => x.Sessions)
                .HasForeignKey(x => x.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("Capacity_Constraint", "Capacity > 0 and Capacity <= 25");
                T.HasCheckConstraint("StartTime_Constraint", "StartTime < EndTime");
            });
        }
    }
}
