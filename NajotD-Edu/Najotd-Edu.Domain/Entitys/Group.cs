namespace Najotd_Edu.Domain.Entitys
{
    public class Group
    {
        public Group()
        {
            Lessons = new HashSet<Lesson>();
            StudentGroups = new HashSet<StudentGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TeacherId { get; set; }
        public User Teacher { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<StudentGroup> StudentGroups { get; set; }

    }
}
