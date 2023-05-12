using IIS_Projekat.Models.DTOs.Allergy;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface IAllergyService
    {
        PaginationWrapper<PreviewAllergyDTO> GetAll(PaginationQuery paginationQuery);
        long Create(NewAllergyDTO newAllergyDTO);
    }
}
