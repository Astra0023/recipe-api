using application.Interfaces;
using domain.Entities;
using infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly AppDbContext _context;
        public IngredientRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Ingredient> GetIngredientByIdAsync(int ingredientId, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _context.Ingredients
                    .Where(x => x.IngredientId == ingredientId)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(cancellationToken);
                
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Ingredient>> GetAllIngredientsAsync(CancellationToken cancellationToken)
        {
            try
            {
                return await _context.Ingredients
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
