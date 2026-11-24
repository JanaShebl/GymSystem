using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Configurations
{
    public class MemberConfig:GymUserConfig<Member>, IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            base.Configure(builder);

            builder.Property(x=>x.CreatedAt)
                .HasColumnName("JoinedDate")
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
