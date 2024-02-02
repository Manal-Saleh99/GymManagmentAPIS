using GymManagmentAPIS.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentAPIS.Models.EntityConfigriation
{
    public class ClientEntityConfigriation : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");

            builder.HasKey(x => x.ClientId);

            builder.Property(x => x.FirstName).HasMaxLength(20);

            builder.Property(x => x.LastName).HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(20);

            builder.Property(x => x.Password).HasMaxLength(10);


            builder .Property (x=>x.Phone ).HasMaxLength(10);


        }
    }
}
