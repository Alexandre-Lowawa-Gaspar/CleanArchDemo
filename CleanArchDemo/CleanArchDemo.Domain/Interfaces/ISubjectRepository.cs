using CleanArchDemo.Domain.Entities;

namespace CleanArchDemo.Domain.Interfaces
{
    public interface ISubjectRepository : IRepositoryBase<Subject>
    {
        Task<IEnumerable<Subject>> GetAllAsync();

        Task<Subject> GetByIdAsync(Guid id);

        IQueryable<Subject> GetQueryable();

        void Add(Subject entity);

        void Update(Subject entity);

        void DeleteAsync(Subject entity);
    }
}