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
    public class AttendanceEntityTypeConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Lesson)
                .WithMany(x => x.Attendances)
                .HasForeignKey(x => x.LessonId);

            builder.HasOne(x => x.Student)
                .WithMany(x => x.Attendances)
                .HasForeignKey(x => x.StudentId);
        }
    }
}
