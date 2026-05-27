using domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Configurations
{
    public sealed class RecipeIngredientConfiguration
    : IEntityTypeConfiguration<RecipeIngredient>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredient> builder)
        {
            builder.ToTable("t_lookup_recipe_ingredients");
            builder.Property(x => x.IngredientId)
                .HasColumnName("ingredient_id");
            builder.Property(x => x.RecipeId)
                .HasColumnName("recipe_id");
            builder.Property(x => x.Quantity)
               .HasColumnName("quantity");
            builder.Property(x => x.Unit)
               .HasColumnName("unit");
            builder.HasKey(x => x.RecipeIngredientId);
            builder.HasOne(x => x.Recipe)
                .WithMany(x => x.RecipeIngredients)
                .HasForeignKey(x => x.RecipeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Ingredient)
                .WithMany(x => x.RecipeIngredients)
                .HasForeignKey(x => x.IngredientId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasIndex(x => new
            {
                x.RecipeId,
                x.IngredientId
            }).IsUnique();
        }
    }
}
