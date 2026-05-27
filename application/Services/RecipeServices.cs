using application.Dtos;
using application.Interfaces;
using domain.Entities;

namespace application.Services
{
    public sealed class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _repository;

        public RecipeService(IRecipeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<RecipeResponseDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var recipes = await _repository.GetAllAsync(cancellationToken);

            return recipes.Select(recipe => new RecipeResponseDto
            {
                RecipeId = recipe.RecipeId,
                Name = recipe.Name,
                Description = recipe.Description,
                Author = recipe.Author,

                Ingredients = recipe.RecipeIngredients
                    .Select(x => new RecipeIngredientDto
                    {
                        IngredientId = x.IngredientId,
                        IngredientName = x.Ingredient.Name,
                        Quantity = x.Quantity,
                        Unit = x.Unit
                    })
                    .ToList()
            }).ToList();
        }

        public async Task CreateAsync(CreateRecipeDto dto, CancellationToken cancellationToken = default)
        {
            var recipe = new Recipe
            {
                Name = dto.Name,
                Description = dto.Description,
                Author = dto.Author,

                RecipeIngredients = dto.Ingredients
                    .Select(x => new RecipeIngredient
                    {
                        IngredientId = x.IngredientId,
                        Quantity = x.Quantity,
                        Unit = x.Unit
                    })
                    .ToList()
            };

            await _repository.AddAsync(recipe, cancellationToken);
        }
    }
}
