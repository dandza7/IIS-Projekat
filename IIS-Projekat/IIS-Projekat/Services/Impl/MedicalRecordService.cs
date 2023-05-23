using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.MedicalRecord;
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
    }
}
