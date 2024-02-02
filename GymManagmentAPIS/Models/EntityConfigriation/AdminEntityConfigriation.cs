using GymManagmentAPIS.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentAPIS.Models.EntityConfigriation
{
    public class AdminEntityConfigriation : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admin");

            builder.HasKey(x => x.AdminId );

            builder.Property(x => x.FirstName ).HasMaxLength(20);

            builder.Property(x => x.LastName ).HasMaxLength(20);
            builder.Property(x => x.Email ).HasMaxLength(20);

            builder.Property(x => x.Password ).HasMaxLength(10);
        }
    }
}
