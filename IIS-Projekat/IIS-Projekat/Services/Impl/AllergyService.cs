using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Allergy;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace IIS_Projekat.Services.Impl
{
    public class AllergyService : IAllergyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AllergyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public PaginationWrapper<PreviewAllergyDTO> GetAll(PaginationQuery paginationQuery)
        {
            var paginationResult = _unitOfWork.AllergyRepository.Filter(paginationQuery);
            return new PaginationWrapper<PreviewAllergyDTO>(_mapper.Map<List<PreviewAllergyDTO>>(paginationResult.Items), paginationResult.TotalCount);
        }

        public long Create(NewAllergyDTO newAllergyDTO)
        {
            if (_unitOfWork.AllergyRepository.GetAll().Where(a => a.Name == newAllergyDTO.Name).Any())
            {
                throw new DuplicateItemException("Allergy with sent name already exists!");
            }
            var newAllergy = _unitOfWork.AllergyRepository.Create(_mapper.Map<Allergy>(newAllergyDTO));
            _unitOfWork.SaveChanges();
            return newAllergy.Id;
        }
    }
}
