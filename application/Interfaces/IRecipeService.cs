using application.Dtos;

namespace application.Interfaces
{
    public interface IRecipeService
    {
        Task<List<RecipeResponseDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task CreateAsync(CreateRecipeDto dto, CancellationToken cancellationToken = default);
    }
}
