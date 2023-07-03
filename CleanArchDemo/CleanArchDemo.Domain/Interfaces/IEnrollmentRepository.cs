using CleanArchDemo.Domain.Entities;

namespace CleanArchDemo.Domain.Interfaces
{
    public interface IEnrollmentRepository : IRepositoryBase<Enrollment>
    {
        Task<IEnumerable<Enrollment>> GetAllAsync();

        Task<Enrollment> GetByIdAsync(Guid id);

        IQueryable<Enrollment> GetQueryable();

        void Add(Enrollment entity);

        void Update(Enrollment entity);

        void DeleteAsync(Enrollment entity);
    }
}