using CleanArchDemo.Domain.Entities;

namespace CleanArchDemo.Domain.Interfaces
{
    public interface IFinalEvaluationRepository : IRepositoryBase<FinalEvaluation>
    {
        Task<IEnumerable<FinalEvaluation>> GetAllAsync();

        Task<FinalEvaluation> GetByIdAsync(Guid id);

        IQueryable<FinalEvaluation> GetQueryable();

        void Add(FinalEvaluation entity);

        void Update(FinalEvaluation entity);

        void DeleteAsync(FinalEvaluation entity);
    }
}