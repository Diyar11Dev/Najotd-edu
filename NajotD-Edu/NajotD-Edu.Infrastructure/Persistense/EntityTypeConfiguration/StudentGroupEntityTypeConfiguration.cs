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
    public class StudentGropuEntityTypeConfiguration : IEntityTypeConfiguration<StudentGroup>
    {
        public void Configure(EntityTypeBuilder<StudentGroup> builder)
        {
            builder.HasKey(x => x.Id);


            builder.HasOne(x => x.Student)
                .WithMany(x => x.StudentGroups)
                .HasForeignKey(x => x.StudentId);

            builder.HasOne(x => x.Group)
                .WithMany(x => x.StudentGroups)
                .HasForeignKey(x => x.GroupId);
        }
    }
}
