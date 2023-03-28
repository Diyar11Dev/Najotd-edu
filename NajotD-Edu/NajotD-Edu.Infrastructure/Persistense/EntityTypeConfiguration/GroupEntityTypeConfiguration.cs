using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Najotd_Edu.Domain.Entitys;


namespace NajotD_Edu.Infrastructure.Persistense.EntityTypeConfiguration
{
    public class GroupEntityTypeConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasOne(x => x.Teacher)
                .WithMany(x => x.Groups)
                .HasForeignKey(x => x.TeacherId);
        }
    }
}