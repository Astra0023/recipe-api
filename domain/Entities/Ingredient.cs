namespace domain.Entities
{
    public sealed class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public int IngredientTypeId { get; set; }
        public IngredientType IngredientType { get; set; } = default!;
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
    }
}
