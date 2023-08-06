using IIS_Projekat.Models.DTOs.Measurement;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface IMeasurementService
    {
        public long CreateMeasurement(NewMeasurementDTO newMeasurementDTO, string email);
        public PaginationWrapper<PreviewMeasurementDTO> GetMeasurementsForPatient(long id, MeasurementFilterQuery filter);
    }
}
