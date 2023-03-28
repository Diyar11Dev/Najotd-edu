using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Najotd_Edu.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
