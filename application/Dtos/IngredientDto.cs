namespace application.Dtos
{
    public class IngredientDto : CommonDto
    {
        public int IngredientId { get; set; }
        public int IngredientTypeId { get; set; }
        public IngredientTypeDto? IngredientTypes { get; set; }
    }
}
