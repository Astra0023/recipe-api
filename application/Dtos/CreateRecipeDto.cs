namespace application.Dtos
{
    public sealed class CreateRecipeDto
    {
        public string Name { get; set; } = default!;

        public string? Description { get; set; }

        public string Author { get; set; } = default!;

        public List<CreateRecipeIngredientDto> Ingredients { get; set; } = [];
    }
}
