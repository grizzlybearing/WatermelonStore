using AutoMapper;
using API.BusinessLogicLayer.DTO.User;
using API.BusinessLogicLayer.Interfaces;
using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Models;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> GetUserByIdAsync(Guid userId, CancellationToken cancellationToken = default)
        {
            var user = await _userRepository.GetAsync(userId, cancellationToken);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> CreateUserAsync(UserAddDTO userAddDTO, CancellationToken cancellationToken = default)
        {
            var user = _mapper.Map<User>(userAddDTO);
            await _userRepository.CreateAsync(user, cancellationToken);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task UpdateUserAsync(UserUpdateDTO userUpdateDTO, CancellationToken cancellationToken = default)
        {
            var user = _mapper.Map<User>(userUpdateDTO);
            await _userRepository.UpdateAsync(user, cancellationToken);
        }

        public async Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken = default)
        {
            await _userRepository.DeleteAsync(userId, cancellationToken);
        }
    }
}
