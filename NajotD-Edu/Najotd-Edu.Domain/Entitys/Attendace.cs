using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Najotd_Edu.Domain.Entitys
{
    public class Attendance
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public bool HasParticipated { get; set; }
        public Student Student { get; set; }
        public Lesson Lesson { get; set; }
    }
}
