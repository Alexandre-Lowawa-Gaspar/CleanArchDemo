using CleanArchDemo.Domain.Entities;

namespace CleanArchDemo.Domain.Interfaces
{
    public interface ICourseRepository : IRepositoryBase<Course>
    {
        Task<IEnumerable<Course>> GetAllAsync();

        Task<Course> GetByIdAsync(Guid id);

        IQueryable<Course> GetQueryable();

        void Add(Course entity);

        void Update(Course entity);

        void DeleteAsync(Course entity);
    }
}