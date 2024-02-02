using GymManagmentAPIS.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentAPIS.Models.EntityConfigriation
{
    public class EmployeeEntityConfigriation : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(x => x.EmployeeId );

            builder.Property(x => x.FirstName).HasMaxLength(20);

            builder.Property(x => x.LastName).HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(20);

            builder.Property(x => x.Password).HasMaxLength(10);


            builder.Property(x => x.Phone).HasMaxLength(10);

            builder.ToTable(x => x.HasCheckConstraint("CH_Coach_Age", "Age>= 18"));

        }
    }
}
