using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models.DTOs.Training.Session;

namespace IIS_Projekat.Services
{
    public interface ITrainingSessionService
    {
        public ShouldDocumentNewTrainingSessionDTO ShouldDocumentNewSessionDTO(string email);
        public void DocumentNewTrainingSession(string email, NewDocumentedTrainingSessionDTO session);
    }
}
