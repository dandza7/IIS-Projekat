using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.Models.DTOs.MedicalRecord;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Patient;
using IIS_Projekat.Models.DTOs.Training.Request;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace IIS_Projekat.Services.Impl
{
    public class MedicalRecordService : IMedicalRecordService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MedicalRecordService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long Create(MedicalRecordDTO newMedicalRecord)
        {
            var patient = _unitOfWork.UserRepository.GetById(newMedicalRecord.PatientId);
            if(patient == null)
            {
                throw new NotFoundException($"Patient with ID: {newMedicalRecord.PatientId} does not exist in the database.");
            } 
            if(_unitOfWork.MedicalRecordRepository.GetAll().Where(mr => mr.PatientId == newMedicalRecord.PatientId).FirstOrDefault() != null)
            {
                throw new DuplicateItemException($"Patient already has a medical record!");
            }

            MedicalRecord medicalRecord = _mapper.Map<MedicalRecord>(newMedicalRecord);
            medicalRecord.Patient = patient;
            medicalRecord = _unitOfWork.MedicalRecordRepository.Create(medicalRecord);
            _unitOfWork.SaveChanges();
            return medicalRecord.Id;
        }

        public void DeleteExercise(long id)
        {
            var medicalRecord = _unitOfWork.MedicalRecordRepository.GetById(id);
            if(medicalRecord == null)
            {
                throw new NotFoundException($"Medical record with ID: {id} does not exist in the database.");
            }
            _unitOfWork.MedicalRecordRepository.Delete(medicalRecord);
            _unitOfWork.SaveChanges();
        }

        public PaginationWrapper<PreviewMedicalRecordDTO> GetAll(PaginationQuery? paginationQuery)
        {
            var paginationResult = _unitOfWork.MedicalRecordRepository.Filter(paginationQuery, mr => mr.Patient, mr => mr.Patient.Profile);
            return new PaginationWrapper<PreviewMedicalRecordDTO>(_mapper.Map<List<PreviewMedicalRecordDTO>>(paginationResult.Items), paginationResult.TotalCount);
        }

        public PreviewMedicalRecordDTO GetById(long id)
        {
            var medicalRecord = _unitOfWork.MedicalRecordRepository.GetById(id, mr => mr.Patient, mr => mr.Patient.Profile);
            if (medicalRecord == null)
            {
                throw new NotFoundException($"Medical record with ID: {id} does not exist in the database.");
            }
            return _mapper.Map<PreviewMedicalRecordDTO>(medicalRecord);
        }

        public PreviewPatientDetailedDTO GetByPatientId(long patientId)
        {
            var patient = _unitOfWork.UserRepository.GetById(patientId,
                p => p.Profile,
                p => p.MedicalRecord,
                p => p.MedicalRecord.Allergies,
                p => p.MedicalRecord.Diagnoses);
            if(patient == null)
            {
                throw new NotFoundException($"Patient with ID: {patientId} does not exist in the database.");
            }
            return _mapper.Map<PreviewPatientDetailedDTO>(patient);
        }
    }
}
