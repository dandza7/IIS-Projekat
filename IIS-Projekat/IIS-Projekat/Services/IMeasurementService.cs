using IIS_Projekat.Models.DTOs.Measurement;

namespace IIS_Projekat.Services
{
    public interface IMeasurementService
    {
        public long CreateMeasurement(NewMeasurementDTO newMeasurementDTO, string email);
        public ICollection<PreviewMeasurementDTO> GetMeasurementsForPatient(long id, string filter);
    }
}
