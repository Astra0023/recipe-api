namespace application.Dtos
{
    public sealed class RecipeResponseDto
    {
        public int RecipeId { get; set; }

        public string Name { get; set; } = default!;

        public string? Description { get; set; }

        public string Author { get; set; } = default!;

        public List<RecipeIngredientDto> Ingredients { get; set; } = [];
    }
}
