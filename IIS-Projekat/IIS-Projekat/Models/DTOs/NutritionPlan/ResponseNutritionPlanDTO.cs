

namespace IIS_Projekat.Models.DTOs.NutritionPlan
{
    public class ResponseNutritionPlanDTO
    {
        public List<PreviewMealDTO> Breakfasts { get; set; } = new List<PreviewMealDTO>();
        public List<PreviewMealDTO> Lunches { get; set; } = new List<PreviewMealDTO>();
        public List<PreviewMealDTO> Dinners { get; set; } = new List<PreviewMealDTO>();
        public List<PreviewMealDTO> Snacks { get; set; } = new List<PreviewMealDTO>();
        public List<PreviewMealDTO> Supplements { get; set; } = new List<PreviewMealDTO>();
    }
}
