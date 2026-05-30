using application.Dtos;

namespace application.Interfaces
{
    public interface IIngredientService
    {
        Task<List<IngredientDto>> GetAllIngredientsAsync(CancellationToken cancellationToken);
        Task<IngredientDto> GetIngredientByIdAsync(int ingredientId, CancellationToken cancellationToken);
    }
}
