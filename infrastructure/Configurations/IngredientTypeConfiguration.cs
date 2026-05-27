using domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Configurations
{
    public sealed class IngredientTypeConfiguration
     : IEntityTypeConfiguration<IngredientType>
    {
        public void Configure(EntityTypeBuilder<IngredientType> builder)
        {
            builder.ToTable("t_ingredient_types");

            builder.HasKey(x => x.IngredientTypeId);
            builder.Property(x => x.IngredientTypeId)
                .HasColumnName("ingredient_type_id");
            builder.Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnName("description")
                .HasMaxLength(500);

            builder.HasIndex(x => x.Name)
                .IsUnique();
        }
    }
}
