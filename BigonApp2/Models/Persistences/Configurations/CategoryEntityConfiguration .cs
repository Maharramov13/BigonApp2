using BigonApp2.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BigonApp2.Models.Persistences.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(5,2);
            builder.Property(m => m.Name).HasColumnType("varchar").IsRequired().HasMaxLength(50);




            builder.HasOne<Category>()
            .WithMany()
            .HasForeignKey(m =>m.ParentId)
            .OnDelete(DeleteBehavior.NoAction)
            .HasPrincipalKey(m=>m.Id);

            builder.ConfigureAsAuditable();


            builder.HasKey(m => m.Id);
            builder.ToTable("Categories");
        }
    }
}
