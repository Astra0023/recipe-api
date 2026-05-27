using domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Configurations
{
    public sealed class IngredientConfiguration
    : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.ToTable("t_ingredients");
            builder.HasKey(x => x.IngredientId);
            builder.Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(150)
                .IsRequired();
            builder.Property(x => x.Description)
                .HasColumnName("description")
                .HasMaxLength(1000);
            builder.Property(x => x.IngredientTypeId)
                .HasColumnName("type_id");

            builder.HasOne(x => x.IngredientType)
                .WithMany(x => x.Ingredients)
                .HasForeignKey(x => x.IngredientTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => x.Name)
                .IsUnique();
        }
    }
}
