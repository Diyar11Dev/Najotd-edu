using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Najotd_Edu.Domain.Entitys;
using Najotd_Edu.Domain.Enums;

namespace NajotD_Edu.Infrastructure.Persistense.EntityTypeConfiguration
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        void IEntityTypeConfiguration<User>.Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName)
                .HasMaxLength(30)
                .IsRequired();
            builder.HasIndex(i => i.UserName)
                .IsUnique();

            builder.HasData(new User()
            {
                Id = 1,
                UserName = "Admin",
                PasswordHash = "5032E95A5DA27098273D49FFE608CA49C6A40EB756BDAE65431C6D1B5F8213B44963F2CD459B29704A8207CBE3A9CC8D35A6A1FC374078EF4FC08AC0BECD9DD7",
                Role = UserRole.Admin,
                FullName = "Diyor Qurbonboyev",
            });
        }
    }
}
