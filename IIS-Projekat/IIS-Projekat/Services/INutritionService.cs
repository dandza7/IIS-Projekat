using IIS_Projekat.Models.DTOs.NutritionPlan;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface INutritionService
    {
        ResponseNutritionPlanDTO GetOne(NutritionPlanKeyDTO nutritionPlanKeyDTO);
        void Update(NewNutritionPlanDTO newNutritionPlanDTO);
        PaginationWrapper<PreviewNutritionPlanDTO> GetUnorderedNutritionPlans(int page);
        PreviewNutritionPlanContentDTO GetNutritionPlanWithIngredients(long id);
    }
}
