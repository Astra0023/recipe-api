namespace domain.Entities
{
    public sealed class IngredientType
    {
        public int IngredientTypeId { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}
