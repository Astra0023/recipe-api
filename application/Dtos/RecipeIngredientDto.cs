namespace application.Dtos
{
    public sealed class RecipeIngredientDto
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; } = default!;
        public decimal Quantity { get; set; }
        public string Unit { get; set; } = default!;
    }
}
