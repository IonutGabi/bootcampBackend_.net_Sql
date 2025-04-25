using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AcademyManagerWeb.DataAccess.EntityConfig
{
    public class TeacherConfig: IEntityTypeConfiguration<Teacher> 
    {
        public void Configure(EntityTypeBuilder<Teacher> teacherBuilder) 
        {
            teacherBuilder.ToTable("Teachers", t => t.HasComment("Tabla para almacenar los profesores que imparten los cursos"))
                .Property(t => t.Name)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI")
                .IsRequired();

            teacherBuilder.
                Property(t => t.TeacherId)
                .ValueGeneratedOnAdd();


            teacherBuilder
                .Property(t => t.LastName)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI")
                .IsRequired();

            teacherBuilder.HasIndex(t => new { t.Name, t.LastName })
                .IsUnique(true)
                .HasDatabaseName("UX_Teachers_NameLastName");

            teacherBuilder.HasMany(t => t.Courses).WithOne(t => t.Teacher);
        }
    }
}
