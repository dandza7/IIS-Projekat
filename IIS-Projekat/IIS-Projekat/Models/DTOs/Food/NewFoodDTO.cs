namespace IIS_Projekat.Models.DTOs.Food
{
    public class NewFoodDTO
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public float Calories { get; set; }
        public List<int> AllergyIds { get; set; } = new List<int>();
        public NutrientTableDTO NutrientTable { get; set; }
    }
}
