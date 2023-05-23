using IIS_Projekat.Models.DTOs.Therapy;

namespace IIS_Projekat.Services
{
    public interface ITherapyService
    {
        public long Create(TherapyDTO newTherapy);
    }
}
