using AutoMapper;
using IIS_Projekat.Models.DTOs.Measurement;
using IIS_Projekat.Models.DTOs.Training.Plan;
using IIS_Projekat.Repositories;

namespace IIS_Projekat.Services.Impl
{
    public class MeasurementService: IMeasurementService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MeasurementService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long CreateMeasurement(NewMeasurementDTO measurementDTO)
        {
            throw new NotImplementedException();
        }

        public long GetMeasurementForPatient(string email, string filter)
        {
            throw new NotImplementedException();
        }
    }
}
