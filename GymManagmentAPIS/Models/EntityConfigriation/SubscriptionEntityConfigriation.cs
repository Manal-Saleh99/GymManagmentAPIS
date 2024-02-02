using GymManagmentAPIS.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentAPIS.Models.EntityConfigriation
{
    public class SubscriptionEntityConfigriation : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("Subscription");

            builder.HasKey(x => x.SubscriptionId );

            builder.Property(x => x.SubscriptionName ).HasMaxLength(60);

            
            builder.Property(x => x.Description).HasMaxLength(120);
            builder.ToTable(x => x.HasCheckConstraint("CH_Subscription_Price", "Price>= 20"));

        }
    }
}
