using issuespot_backend.Database;
using Microsoft.EntityFrameworkCore;

namespace issuespot_backend.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public readonly AppDbContext _context;
        protected readonly DbSet<TEntity> _table;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _table = context.Set<TEntity>();
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _table.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            var allItems = await _table.AsNoTracking().ToListAsync();
            return allItems;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _table.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
