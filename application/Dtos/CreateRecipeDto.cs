namespace application.Dtos
{
    public sealed class CreateRecipeDto : CommonDto
    {
        public string Author { get; set; } = default!;

        public List<CreateRecipeIngredientDto> Ingredients { get; set; } = [];
    }
}
