using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Therapy;

namespace IIS_Projekat.Services
{
    public interface ITherapyService
    {
        public long Create(TherapyDTO newTherapy);
        public void Delete(long Id);
        public PreviewTherapyDTO GetById(long id);
        public PaginationWrapper<PreviewTherapyDTO> GetAll(PaginationQuery? paginationQuery);
    }
}
