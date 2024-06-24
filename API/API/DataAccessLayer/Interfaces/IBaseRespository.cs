using API.DataAccessLayer.Models;

namespace API.DataAccessLayer.Interfaces
{
    public interface IBaseRespository<T> where T : BaseModel
    {
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<T?> GetAsync(Guid id, CancellationToken cancellationToken = default);
        Task<T> CreateAsync(T newEntity, CancellationToken cancellationToken = default);
        Task<T> UpdateAsync(T newEntity, CancellationToken cancellationToken = default);
        Task<int> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
