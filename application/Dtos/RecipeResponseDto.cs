namespace application.Dtos
{
    public sealed class RecipeResponseDto : CommonDto
    {
        public int RecipeId { get; set; }

        public string Author { get; set; } = default!;

        public List<RecipeIngredientDto> Ingredients { get; set; } = [];
    }
}
