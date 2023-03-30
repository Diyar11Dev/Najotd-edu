namespace Najotd_Edu.Domain.Entitys
{
    public class Lesson
    {
        public Lesson()
        {
            Attendances = new HashSet<Attendance>();
        }

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}
