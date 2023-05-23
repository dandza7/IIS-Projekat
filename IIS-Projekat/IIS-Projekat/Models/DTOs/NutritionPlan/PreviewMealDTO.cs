using IIS_Projekat.Models.DTOs.Recipe;

namespace IIS_Projekat.Models.DTOs.NutritionPlan
{
    public class PreviewMealDTO
    {
        public PreviewRecipeDetailedDTO Recipe { get; set; }
        public float PortionSize { get; set; }
    }
}
