using application.Dtos;
using application.Interfaces;

namespace application.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;
        public IngredientService(IIngredientRepository ingredientRepository) 
        {
            _ingredientRepository = ingredientRepository;
        }

        public async Task<List<IngredientDto>> GetAllIngredientsAsync(CancellationToken cancellationToken)
        {
            var ingredients = await _ingredientRepository.GetAllIngredientsAsync(cancellationToken);
            return ingredients.Select(ingredient => new IngredientDto
            {
                IngredientId = ingredient.IngredientId,
                Name = ingredient.Name,
                Description = ingredient.Description,
                IngredientTypeId = ingredient.IngredientTypeId
            }).ToList();
        }

        public async Task<IngredientDto> GetIngredientByIdAsync(int ingredientId, CancellationToken cancellationToken)
        {
            var ingredient = await _ingredientRepository.GetIngredientByIdAsync(ingredientId, cancellationToken);
            return new IngredientDto
            {
                IngredientId = ingredient.IngredientId,
                Name = ingredient.Name,
                Description = ingredient.Description,
                IngredientTypeId = ingredient.IngredientTypeId
            };
        }
    }
}
