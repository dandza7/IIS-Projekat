using AutoMapper;
using IIS_Projekat.Repositories;

namespace IIS_Projekat.Services.Impl
{
    public class NutritionService : INutritionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NutritionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
