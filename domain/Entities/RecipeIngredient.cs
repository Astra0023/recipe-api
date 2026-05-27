namespace domain.Entities
{
    public sealed class RecipeIngredient
    {
        public int RecipeIngredientId { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; } = default!;
        public Recipe Recipe { get; set; } = default!;
        public Ingredient Ingredient { get; set; } = default!;
    }
}
