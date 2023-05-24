using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.Models.DTOs.MedicalRecord;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Patient;

namespace IIS_Projekat.Services
{
    public interface IMedicalRecordService
    {
        public long Create(MedicalRecordDTO newMedicalRecord);
        public PaginationWrapper<PreviewMedicalRecordDTO> GetAll(PaginationQuery? paginationQuery);
        public PreviewMedicalRecordDTO GetById(long id);
        public void DeleteExercise(long id);
    }
}
