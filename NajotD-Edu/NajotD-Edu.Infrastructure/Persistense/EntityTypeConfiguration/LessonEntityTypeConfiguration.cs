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
    public class LessonEntityTypeConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasKey(x => x.Id);


        }
    }
}
