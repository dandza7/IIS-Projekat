using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models.DTOs.Training.Exercise;
using IIS_Projekat.Models.DTOs.Training.Session;

namespace IIS_Projekat.Services
{
    public interface ITrainingSessionService
    {
        public PaginationWrapper<PreviewDocumentedSessionDTO> GetSessionForClient(TrainnigSessionPaginationDTO query, string email);
        public ShouldDocumentNewTrainingSessionDTO ShouldDocumentNewSession(string email);
        public void DocumentNewTrainingSession(string email, NewDocumentedTrainingSessionDTO session);
    }
}
