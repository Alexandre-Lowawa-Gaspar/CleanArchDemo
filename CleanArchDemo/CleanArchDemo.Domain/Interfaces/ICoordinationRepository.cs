using CleanArchDemo.Domain.Entities;

namespace CleanArchDemo.Domain.Interfaces
{
    public interface ICoordinationRepository : IRepositoryBase<Coordination>
    {
        Task<IEnumerable<Coordination>> GetAllAsync();

        Task<Coordination> GetByIdAsync(Guid id);

        IQueryable<Coordination> GetQueryable();

        void Add(Coordination entity);

        void Update(Coordination entity);

        void DeleteAsync(Coordination entity);
    }
}