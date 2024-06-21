using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DataAccessLayer.Repositories
{
    public abstract class BaseRepository<T> : IBaseRespository<T> where T : BaseModel
    {
        private ShopdbContext _context;

        protected BaseRepository(ShopdbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Set<T>().ToListAsync(cancellationToken);
        }

        public async Task<T?> GetAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var res = await _context.Set<T>().Where(entity => entity.Id == id)
                .AsNoTracking().FirstOrDefaultAsync(cancellationToken);
            return res;
        }

        public async Task<T> CreateAsync(T newEntity, CancellationToken cancellationToken = default)
        {
            await _context.AddAsync(newEntity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return newEntity;
        }

        public async Task<T> UpdateAsync(T newEntity, CancellationToken cancellationToken = default)
        {
            _context.Update(newEntity);
            await _context.SaveChangesAsync(cancellationToken);
            return newEntity;
        }

        public async Task<int> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            int res = await _context.Set<T>().Where(entity => entity.Id == id)
                .AsNoTracking().ExecuteDeleteAsync(cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return res;
        }
    }
}
