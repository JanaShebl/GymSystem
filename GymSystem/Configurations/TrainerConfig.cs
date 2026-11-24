using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Configurations
{
    public class TrainerConfig : GymUserConfig<Trainer>,IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.CreatedAt)
                .HasColumnName("HiredDate")
                .HasDefaultValueSql("GETDATE()");
        }
    
    }
}
