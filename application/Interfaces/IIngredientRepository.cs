using domain.Entities;

namespace application.Interfaces
{
    public interface IIngredientRepository
    {
        Task<List<Ingredient>> GetAllIngredientsAsync(CancellationToken cancellationToken);
        Task<Ingredient> GetIngredientByIdAsync(int ingredientId, CancellationToken cancellationToken);
    }
}
