namespace IIS_Projekat.Models.DTOs.Recipe
{
    public class NewRecipeDTO
    {
        public string Name { get; set; }
        public ICollection<NewIngredientDTO> Ingredients { get; set; } = new List<NewIngredientDTO>();
    }
}
