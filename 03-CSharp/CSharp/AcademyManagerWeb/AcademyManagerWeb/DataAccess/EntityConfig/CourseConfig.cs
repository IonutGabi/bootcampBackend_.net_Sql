using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AcademyManagerWeb.DataAccess.EntityConfig
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> courseBuilder) 
        {
            courseBuilder.ToTable("Courses", t => t.HasComment("Tabla para almacenar los cursos"))
                .Property(c => c.CourseId)
                .ValueGeneratedOnAdd();

            courseBuilder
                .Property(c => c.CourseName)
                .HasMaxLength(150)
                .IsRequired();

            courseBuilder
                .Property(c => c.Description)
                .HasMaxLength(200)
                .IsRequired();
            courseBuilder.HasIndex(c => c.CourseName)
                .IsUnique(true)
                .HasDatabaseName("UX_Courses_CourseName");
        }
    }
}
