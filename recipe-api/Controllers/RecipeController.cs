using application.Dtos;
using application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace recipe_api.Controllers
{
    [ApiController]
    [Route("api/recipes")]
    public sealed class RecipesController : ControllerBase
    {
        private readonly IRecipeService _service;
        public RecipesController(IRecipeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IResult> GetAll(CancellationToken cancellationToken)
        {
            var recipes = await _service.GetAllAsync(cancellationToken);

            return Results.Ok(recipes);
        }

        [HttpPost]
        public async Task<IResult> Create(CreateRecipeDto dto, CancellationToken cancellationToken)
        {
            await _service.CreateAsync(dto, cancellationToken);
            return Results.Created();
        }
    }
}
