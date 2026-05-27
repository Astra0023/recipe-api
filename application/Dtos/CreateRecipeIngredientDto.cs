namespace application.Dtos
{
    public sealed class CreateRecipeIngredientDto
    {
        public int IngredientId { get; set; }

        public decimal Quantity { get; set; }

        public string Unit { get; set; } = default!;
    }
}
