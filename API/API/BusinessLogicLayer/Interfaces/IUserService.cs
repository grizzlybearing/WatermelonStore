using API.BusinessLogicLayer.DTO.User;

namespace API.BusinessLogicLayer.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> GetUserByIdAsync(Guid userId, CancellationToken cancellationToken = default);
        Task<UserDTO> CreateUserAsync(UserAddDTO userAddDTO, CancellationToken cancellationToken = default);
        Task UpdateUserAsync(UserUpdateDTO userUpdateDTO, CancellationToken cancellationToken = default);
        Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken = default);
    }
}
