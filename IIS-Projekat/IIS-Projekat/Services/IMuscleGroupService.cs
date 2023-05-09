using IIS_Projekat.Models.DTOs.MuscleGroup;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface IMuscleGroupService
    {
        public PaginationWrapper<MuscleGroupDTO> GetAll(PaginationQuery? paginationQuery);
    }
}
