using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Supplement;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace IIS_Projekat.Services.Impl
{
    public class SupplementService : ISupplementService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SupplementService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long Create(NewSupplementDTO newSupplementDTO)
        {
            var supplement = _mapper.Map<Supplement>(newSupplementDTO);
            supplement = _unitOfWork.SupplementRepository.Create(supplement);
            _unitOfWork.SaveChanges();
            return supplement.Id;
        }

        public void Delete(long id)
        {
            var supplement = _unitOfWork.SupplementRepository.GetById(id);
            if(supplement == null)
            {
                throw new NotFoundException($"Supplement with id: {id} does not exist in the database.");
            }
            _unitOfWork.SupplementRepository.Delete(supplement);
            _unitOfWork.SaveChanges();
        }

        public PaginationWrapper<PreviewSupplementDTO> GetAll(PaginationQuery paginationQuery)
        {
            var paginationResult = _unitOfWork.SupplementRepository.Filter(paginationQuery);
            return new PaginationWrapper<PreviewSupplementDTO>(_mapper.Map<List<PreviewSupplementDTO>>(paginationResult.Items), paginationResult.TotalCount);
        }

        public long Update(UpdateSupplementDTO updateSupplementDTO)
        {
            var supplement = _unitOfWork.SupplementRepository.GetById(updateSupplementDTO.Id);
            if (supplement == null)
            {
                throw new NotFoundException($"Supplement with id: {updateSupplementDTO.Id} does not exist in the database.");
            }
            supplement = _mapper.Map<Supplement>(updateSupplementDTO);
            supplement = _unitOfWork.SupplementRepository.Update(supplement);
            _unitOfWork.SaveChanges();
            return supplement.Id;
        }
    }
}
