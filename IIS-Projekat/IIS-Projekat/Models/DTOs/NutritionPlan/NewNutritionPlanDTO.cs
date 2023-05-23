namespace IIS_Projekat.Models.DTOs.NutritionPlan
{
    public class NewNutritionPlanDTO
    {
        public long UserId { get; set; }
        public DateTime Date { get; set; }
        public List<NewMealDTO> Breakfasts { get; set; } = new List<NewMealDTO>();
        public List<NewMealDTO> Lunches { get; set; } = new List<NewMealDTO>();
        public List<NewMealDTO> Dinners { get; set; } = new List<NewMealDTO>();
        public List<NewMealDTO> Snacks { get; set; } = new List<NewMealDTO>();
    }
}
