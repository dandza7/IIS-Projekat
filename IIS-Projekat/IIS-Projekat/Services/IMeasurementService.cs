using IIS_Projekat.Models.DTOs.Measurement;

namespace IIS_Projekat.Services
{
    public interface IMeasurementService
    {
        public long CreateMeasurement(NewMeasurementDTO newMeasurementDTO);
        public long GetMeasurementForPatient(string email, string filter);
    }
}
