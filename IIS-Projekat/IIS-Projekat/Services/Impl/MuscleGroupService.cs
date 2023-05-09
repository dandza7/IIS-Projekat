using AutoMapper;
using IIS_Projekat.Models.DTOs.MuscleGroup;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Repositories;

namespace IIS_Projekat.Services.Impl
{
    public class MuscleGroupService : IMuscleGroupService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MuscleGroupService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public PaginationWrapper<MuscleGroupDTO> GetAll(PaginationQuery? paginationQuery)
        {
            var paginationResult = _unitOfWork.MuscleGroupRepository.Filter(paginationQuery);
            return new PaginationWrapper<MuscleGroupDTO>(_mapper.Map<List<MuscleGroupDTO>>(paginationResult.Items), paginationResult.TotalCount);
        }
    }
}
