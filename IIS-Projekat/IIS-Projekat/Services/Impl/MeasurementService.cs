using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Measurement;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using IIS_Projekat.Repositories;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training.Request;

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

        public long CreateMeasurement(NewMeasurementDTO measurementDTO, string email)
        {
            var patient = _unitOfWork.UserRepository.GetAll().Where(p => p.Email == email).FirstOrDefault();
            if (patient == null)
            {
                throw new NotFoundException($"Patient with given email does not exist!");
            }
            var medicalRecord = _unitOfWork.MedicalRecordRepository.GetAll().Where(mr => mr.PatientId == patient.Id).FirstOrDefault();
            if (medicalRecord == null)
            {
                throw new NotFoundException("Patient does not have medical record!");
            }
            var measurement = _mapper.Map<Measurement>(measurementDTO);
            measurement.MedicalRecord = medicalRecord;
            measurement.MedicalRecordId = medicalRecord.Id;
            measurement = _unitOfWork.MeasurementRepository.Create(measurement);
            _unitOfWork.SaveChanges();
            return measurement.Id;
        }

        public PaginationWrapper<PreviewMeasurementDTO> GetMeasurementsForPatient(PaginationQuery? paginationQuery, long id, string filter)
        {
            var patient = _unitOfWork.UserRepository.GetById(id);
            if (patient == null)
            {
                throw new NotFoundException("Paitnet with given email does not exist!");
            }
            var medicalRecord = _unitOfWork.MedicalRecordRepository.GetAll().Where(mr => mr.PatientId == patient.Id).FirstOrDefault();
            if (medicalRecord == null)
            {
                throw new NotFoundException("Patient does not have medical record!");
            }
            ICollection<Measurement> measurements = new List<Measurement>();
            switch (filter) {
                case "Monthly":
                    measurements = _unitOfWork.MeasurementRepository.GetAll().
                        Where(m => m.MedicalRecordId == medicalRecord.Id && m.CreatedDate >=  DateTime.UtcNow.AddDays(-30)).ToList();
                    break;
                case "Yearly":
                    measurements = _unitOfWork.MeasurementRepository.GetAll().
                        Where(m => m.MedicalRecordId == medicalRecord.Id && m.CreatedDate >= DateTime.UtcNow.AddYears(-1)).ToList();
                    break;
                default:
                    measurements = _unitOfWork.MeasurementRepository.GetAll().
                        Where(m => m.MedicalRecordId == medicalRecord.Id).ToList();
                    break;
            }
            return new PaginationWrapper<PreviewMeasurementDTO>(
                _mapper.Map<List<PreviewMeasurementDTO>>(measurements.Skip((paginationQuery.Page - 1) * paginationQuery.PageSize).Take(paginationQuery.PageSize)),
                measurements.Count
            );
        }
    }
}
