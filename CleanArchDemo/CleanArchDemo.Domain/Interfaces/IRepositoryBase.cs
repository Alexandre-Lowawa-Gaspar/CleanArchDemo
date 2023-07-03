namespace CleanArchDemo.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(Guid id);

        IQueryable<TEntity> GetQueryable();

        void Add(TEntity entity);

        void Update(TEntity entity);

        void DeleteAsync(TEntity entity);

        Task SaveChangesaAsync();
    }
}