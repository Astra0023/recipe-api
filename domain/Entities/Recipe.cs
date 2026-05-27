namespace domain.Entities
{
    public sealed class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string Author { get; set; } = default!;
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }  = new List<RecipeIngredient>();
    }
}
