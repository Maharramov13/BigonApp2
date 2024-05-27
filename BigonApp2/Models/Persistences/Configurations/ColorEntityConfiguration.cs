using BigonApp2.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BigonApp2.Models.Persistences.Configurations
{
    public class ColorEntityConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(5,2);
            builder.Property(m => m.Name).HasColumnType("varchar").IsRequired().HasMaxLength(20);
            builder.Property(m => m.HexCode).HasColumnType("varchar").IsRequired().HasMaxLength(10);


            //builder.Property(m=>m.CreatedBy).HasColumnType("int").IsRequired();
            //builder.Property(m=>m.CreatedAt).HasColumnType("datetime").IsRequired();

            //builder.Property(m => m.ModifiedBy).HasColumnType("int");
            //builder.Property(m => m.ModifiedAt).HasColumnType("datetime");
            //builder.Property(m => m.DeletedBy).HasColumnType("int");
            //builder.Property(m => m.DeletedAt).HasColumnType("datetime");
            builder.ConfigureAsAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("Colors");
        }
    }
}
