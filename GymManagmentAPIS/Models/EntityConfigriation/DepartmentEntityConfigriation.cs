using GymManagmentAPIS.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentAPIS.Models.EntityConfigriation
{
    public class DepartmentEntityConfigriation : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");

            builder.HasKey(x => x.DepartmentId );

            builder.Property(x => x.ArabicName ).HasMaxLength(60);

            builder.Property(x => x.EnglishName ).HasMaxLength(60);
            builder.Property(x => x.Description ).HasMaxLength(120);

        }
    }
}
