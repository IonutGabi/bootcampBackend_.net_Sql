using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AcademyManagerWeb.DataAccess.EntityConfig
{
    public class ProfileConfig: IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> profileBuilder)
        {
            profileBuilder.ToTable("Profiles", t => t.HasComment("Tabla para almacenar los perfiles de los profesores"))
                .Property(p => p.ProfileId)
                .ValueGeneratedOnAdd();

            profileBuilder.Property(p => p.Biography)
                .HasMaxLength(1000)
                .IsRequired();

            profileBuilder.HasOne(p => p.Teacher).WithOne(p => p.Profile).IsRequired(true);
        }
    }
}
