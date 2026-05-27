using domain.Entities;

namespace application.Interfaces
{
    public interface IRecipeRepository
    {
        Task<List<Recipe>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Recipe?> GetByIdAsync(int recipeId, CancellationToken cancellationToken = default);
        Task AddAsync(Recipe recipe, CancellationToken cancellationToken = default);
    }
}
