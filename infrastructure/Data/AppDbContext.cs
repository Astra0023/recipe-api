using domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Data
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes => Set<Recipe>();

        public DbSet<RecipeIngredient> RecipeIngredients => Set<RecipeIngredient>();

        public DbSet<Ingredient> Ingredients => Set<Ingredient>();

        public DbSet<IngredientType> IngredientTypes => Set<IngredientType>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
