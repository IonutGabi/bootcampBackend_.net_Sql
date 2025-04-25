using Microsoft.EntityFrameworkCore;
namespace AcademyManagerWeb.DataAccess
{
    public class AcademyContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Profile> Profile {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AcademyContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public AcademyContext(DbContextOptions<AcademyContext> options) : base(options) 
        {
        }
    }
}
