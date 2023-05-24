using IIS_Projekat.Models.DTOs.Recipe;

namespace IIS_Projekat.Models.DTOs.NutritionPlan
{
    public class PreviewNutritionPlanContentDTO
    {
        public PreviewNutritionPlanDTO Details { get; set; }
        public List<PreviewIngredientDTO> Ingredients { get; set; } = new List<PreviewIngredientDTO>();
    }
}
