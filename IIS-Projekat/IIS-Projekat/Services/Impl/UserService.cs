using AutoMapper;
using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Repositories;

namespace IIS_Projekat.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<PreviewUserDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<PreviewUserDTO>>(_unitOfWork.UserRepository.GetAll().ToList());
        }
    }
}
