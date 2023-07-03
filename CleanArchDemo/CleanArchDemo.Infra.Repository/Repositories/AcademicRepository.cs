using CleanArchDemo.Domain.Entities;
using CleanArchDemo.Domain.Interfaces;
using CleanArchDemo.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchDemo.Infra.Repository.Repositories
{
    public class AcademicRepository : RepositoryBase<Academic>, IAcademicRepository
    {
        private readonly ApplicationDbContext _repository;

        public AcademicRepository(ApplicationDbContext context) : base(context)
        {
            _repository = context;
        }

        public void Add(Academic entity)
        {
            _repository.Set<Academic>().Add(entity);
            _repository.SaveChanges();
        }

        public void DeleteAsync(Academic entity)
        {
            _repository.Set<Academic>().Remove(entity);
            _repository.SaveChanges();
        }

        public async Task<IEnumerable<Academic>> GetAllAsync()
        {
            return await _repository.Set<Academic>().ToListAsync();
        }

        public async Task<Academic> GetByIdAsync(Guid id)
        {
            return await _repository.Set<Academic>().FirstAsync();
        }

        public IQueryable<Academic> GetQueryable()
        {
            return _repository.Set<Academic>();
        }

        public Task SaveChangesaAsync()
        {
            return _repository.SaveChangesAsync();
        }

        public void Update(Academic entity)
        {
            _repository.Set<Academic>().Update(entity);
            _repository.SaveChanges();
        }
    }
}