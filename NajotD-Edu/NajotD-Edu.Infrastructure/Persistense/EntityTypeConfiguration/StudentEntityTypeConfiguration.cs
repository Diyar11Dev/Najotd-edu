using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Najotd_Edu.Domain.Entitys;

namespace NajotD_Edu.Infrastructure.Persistense.EntityTypeConfiguration
{
    public class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.FullName)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
