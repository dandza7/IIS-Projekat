using IIS_Projekat.Models.DTOs.NutritionPlan;

namespace IIS_Projekat.Services
{
    public interface INutritionService
    {
        ResponseNutritionPlanDTO GetOne(NutritionPlanKeyDTO nutritionPlanKeyDTO);
        void Update(NewNutritionPlanDTO newNutritionPlanDTO);
        IEnumerable<PreviewNutritionPlanDTO> GetNutritionPlans();
        PreviewNutritionPlanContentDTO GetNutritionPlanWithIngredients(long id);
    }
}
