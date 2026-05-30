namespace application.Dtos
{
    public class IngredientTypeDto : CommonDto
    {
        public int IngredientTypeId { get; set; }
        public List<IngredientDto> Ingredients { get; set; } = [];
    }
}
