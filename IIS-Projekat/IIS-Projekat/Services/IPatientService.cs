using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Patient;
using IIS_Projekat.Models.DTOs.UsersProfile;

namespace IIS_Projekat.Services
{
    public interface IPatientService
    {
        public PaginationWrapper<PreviewUsersProfileDTO> GetAll(PaginationQuery paginationQuery);
        public PreviewPatientDetailedDTO GetPatientDetailed(long id);
    }
}
