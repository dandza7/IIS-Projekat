using IIS_Projekat.Models.DTOs.Measurement;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training;

namespace IIS_Projekat.Services
{
    public interface IMeasurementService
    {
        public long CreateMeasurement(NewMeasurementDTO newMeasurementDTO, string email);
        public PreviewStatisticsDTO GetStatisticsForPatient(long id, string email, StatisticsFilterDTO query);
    }
}
