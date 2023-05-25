namespace IIS_Projekat.Models.DTOs.Food
{
    public class PreviewFoodDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float Calories { get; set; }
        public List<string> Allergies { get; set; } = new List<string>();
        public NutrientTableDTO NutrientTable { get; set; } = new NutrientTableDTO();
    }
}
