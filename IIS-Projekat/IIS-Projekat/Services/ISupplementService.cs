using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Supplement;

namespace IIS_Projekat.Services
{
    public interface ISupplementService
    {
        public long Create(NewSupplementDTO newSupplementDTO);
        public long Update(UpdateSupplementDTO updateSupplementDTO);
        public PaginationWrapper<PreviewSupplementDTO> GetAll(PaginationQuery paginationQuery);
        public void Delete(long id);
    }
}
