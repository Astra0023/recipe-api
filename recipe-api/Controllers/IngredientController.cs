using application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace recipe_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _service;
        public IngredientController(IIngredientService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IResult> GetAll(CancellationToken cancellationToken)
        {
            var recipes = await _service.GetAllIngredientsAsync(cancellationToken);

            return Results.Ok(recipes);
        }

        [HttpGet("{ingredientId}")]
        public async Task<IResult> GetById([FromRoute] int ingredientId, CancellationToken cancellationToken)
        {
            var result = await _service.GetIngredientByIdAsync(ingredientId, cancellationToken);
            return Results.Ok(result);
        }
    }
}
