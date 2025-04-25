namespace AcademyManagerWeb.DataAccess
{
    public class Student
    {
        public int StudentId { get; set; }

        public required string Name { get; set; }

        public required string LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public List<Course> Courses { get; set; } = [];
    }
}
