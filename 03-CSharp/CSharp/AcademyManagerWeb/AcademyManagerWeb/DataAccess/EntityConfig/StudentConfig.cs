using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AcademyManagerWeb.DataAccess.EntityConfig
{
    public class StudentConfig: IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> studentBuilder)
        {
            studentBuilder
                .ToTable("Students", t => t.HasComment("Tabla para almacenar a los estudiantes"))
                .Property(s => s.StudentId)
                .ValueGeneratedOnAdd();

            studentBuilder
                .Property(s => s.Name)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI")
                .HasMaxLength(150)
                .IsRequired();

            studentBuilder.HasMany(p => p.Courses).WithMany(p => p.Students);

            studentBuilder
                .Property(s => s.LastName)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI")
                .HasMaxLength(150)
                .IsRequired();

            studentBuilder.HasIndex(s => new { s.Name, s.LastName })
                .IsUnique(true)
                .HasDatabaseName("UX_Students_NameLastName");
        }
    }
}
