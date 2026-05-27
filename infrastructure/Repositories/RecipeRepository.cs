using application.Interfaces;
using domain.Entities;
using infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Repositories
{
    public sealed class RecipeRepository : IRecipeRepository
    {
        private readonly AppDbContext _context;

        public RecipeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Recipe>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return await _context.Recipes
                .AsNoTracking()
                .Include(x => x.RecipeIngredients)
                    .ThenInclude(x => x.Ingredient)
                .ToListAsync(cancellationToken);
            }
            catch (Exception ex) 
            {
                throw;
            }
        }

        public async Task<Recipe?> GetByIdAsync(
            int recipeId,
            CancellationToken cancellationToken = default)
        {
            return await _context.Recipes
                .AsNoTracking()
                .Include(x => x.RecipeIngredients)
                    .ThenInclude(x => x.Ingredient)
                .FirstOrDefaultAsync(
                    x => x.RecipeId == recipeId,
                    cancellationToken);
        }

        public async Task AddAsync(Recipe recipe, CancellationToken cancellationToken = default)
        {
            await _context.Recipes.AddAsync(
                recipe,
                cancellationToken);

            await _context.SaveChangesAsync(
                cancellationToken);
        }
    }
}
