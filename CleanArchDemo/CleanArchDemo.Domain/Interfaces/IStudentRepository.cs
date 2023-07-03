using CleanArchDemo.Domain.Entities;

namespace CleanArchDemo.Domain.Interfaces
{
    public interface IStudentRepository : IRepositoryBase<Student>
    {
        Task<IEnumerable<Student>> GetAllAsync();

        Task<Student> GetByIdAsync(Guid id);

        IQueryable<Student> GetQueryable();

        void Add(Student entity);

        void Update(Student entity);

        void DeleteAsync(Student entity);
    }
}