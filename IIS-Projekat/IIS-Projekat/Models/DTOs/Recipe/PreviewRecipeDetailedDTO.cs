using IIS_Projekat.Models.DTOs.Food;

namespace IIS_Projekat.Models.DTOs.Recipe
{
    public class PreviewRecipeDetailedDTO
    {
        public string Name { get; set; }
        public float Calories { get; set; }
        public List<PreviewIngredientDTO> Ingredients { get; set; } = new List<PreviewIngredientDTO>();
        public List<string> Categories { get; set; } = new List<string>();
        public NutrientTableDTO NutrientTable { get; set; } = new NutrientTableDTO();
    }
}
