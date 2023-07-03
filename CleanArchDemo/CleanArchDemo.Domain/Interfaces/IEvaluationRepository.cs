using CleanArchDemo.Domain.Entities;

namespace CleanArchDemo.Domain.Interfaces
{
    public interface IEvaluationRepository : IRepositoryBase<Evaluation>
    {
        Task<IEnumerable<Evaluation>> GetAllAsync();

        Task<Evaluation> GetByIdAsync(Guid id);

        IQueryable<Evaluation> GetQueryable();

        void Add(Evaluation entity);

        void Update(Evaluation entity);

        void DeleteAsync(Evaluation entity);
    }
}