namespace Najotd_Edu.Domain.Entitys
{
    public class Student
    {
        public Student()
        {
            Attendances = new HashSet<Attendance>();
            StudentGroups = new HashSet<StudentGroup>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BrithDate { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<StudentGroup> StudentGroups { get; set; }
    }
}
