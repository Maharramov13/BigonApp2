using BigonApp2.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BigonApp2.Models.Persistences.Configurations
{
    public class SubscriberEntityConfiguration : IEntityTypeConfiguration<Subscriber>
    {
        public void Configure(EntityTypeBuilder<Subscriber> builder)
        {
            builder.Property(m => m.EmailAdress).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(m => m.IsApproved).HasColumnType("bit");
            builder.Property(m => m.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(m => m.ApprovedAt).HasColumnType("datetime");

            builder.HasKey(m => m.EmailAdress);
            builder.ToTable("Subscribers");
        }
    }
}
