namespace IIS_Projekat.Models.DTOs.NutritionPlan
{
    public class NewNutritionPlan
    {
        public long PatientId { get; set; }
        public DateTime Data { get; set; }
        public List<NewMealDTO> Breakfast { get; set; } = new List<NewMealDTO>();
        public List<NewMealDTO> Lunch { get; set; } = new List<NewMealDTO>();
        public List<NewMealDTO> Dinner { get; set; } = new List<NewMealDTO>();
        public List<NewMealDTO> Snack { get; set; } = new List<NewMealDTO>();
    }
}
