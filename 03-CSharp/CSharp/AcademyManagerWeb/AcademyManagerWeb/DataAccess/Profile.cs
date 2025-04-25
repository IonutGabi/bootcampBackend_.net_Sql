namespace AcademyManagerWeb.DataAccess
{
    public class Profile
    {
        public int ProfileId { get; set; }

        public required string Biography { get; set; }

        public string? SocialMediaUrl { get; set; }

        public required Teacher Teacher { get; set; }
    }
}
