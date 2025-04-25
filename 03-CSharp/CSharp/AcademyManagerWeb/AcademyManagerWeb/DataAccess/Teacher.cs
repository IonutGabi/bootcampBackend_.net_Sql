namespace AcademyManagerWeb.DataAccess
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public required string Name { get; set; }

        public required string LastName { get; set; }

        public List<Course> Courses { get; set; } = [];

        public int ProfileId { get; set; }
        public required Profile Profile { get; set; }
    }
}
