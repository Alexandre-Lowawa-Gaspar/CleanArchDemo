using CleanArchDemo.Domain.Entities;

namespace CleanArchDemo.Domain.Interfaces
{
    public interface IAcademicRepository : IRepositoryBase<Academic>
    {
        Task<IEnumerable<Academic>> GetAllAsync();

        Task<Academic> GetByIdAsync(Guid id);

        IQueryable<Academic> GetQueryable();

        void Add(Academic entity);

        void Update(Academic entity);

        void DeleteAsync(Academic entity);
    }
}