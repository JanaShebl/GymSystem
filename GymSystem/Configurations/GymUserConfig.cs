using GymSystem.Entities;
using GymSystem.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GymSystem.Configurations
{
    public class GymUserConfig<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).
                HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(x => x.Email)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.Property(x => x.PhoneNumber)
                .HasColumnType("varchar")
                .HasMaxLength(11);

            builder.ComplexProperty(x => x.Address);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.PhoneNumber).IsUnique();
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("Email_Constraint", "Email LIKE '_%@%.%com'");
                T.HasCheckConstraint("PhoneNumber_Constraint", "LEN(PhoneNumber) = 11 and PhoneNumber LIKE '010%' or PhoneNumber LIKE '011%' or PhoneNumber LIKE '012%' or PhoneNumber LIKE '015%'");
            });
        }
    
    
}
}