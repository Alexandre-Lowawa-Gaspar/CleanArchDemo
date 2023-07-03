using CleanArchDemo.Domain.Interfaces;
using CleanArchDemo.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchDemo.Infra.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : class
    {
        private readonly ApplicationDbContext _context;

        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void DeleteAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _context.Set<TEntity>().FirstAsync();
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return _context.Set<TEntity>();
        }

        public Task SaveChangesaAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
    }
}