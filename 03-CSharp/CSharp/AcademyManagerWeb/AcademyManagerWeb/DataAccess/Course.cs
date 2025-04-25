namespace AcademyManagerWeb.DataAccess
{
    public class Course
    {
        public int CourseId { get; set; }

        public required string CourseName { get; set; }

        public required string Description { get; set; }

        public required Teacher Teacher { get; set; }
        public int TeacherId { get; set; }

        public List<Student> Students { get; set; } = [];
    }
}
