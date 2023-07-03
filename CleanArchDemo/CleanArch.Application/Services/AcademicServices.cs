using CleanArchDemo.Domain.Entities;
using CleanArchDemo.Domain.Interfaces;

namespace CleanArchDemo.Application.Services
{
    public class AcademicServices
    {
        private readonly IAcademicRepository _repository;

        public void Add(Academic entity)
        {
            _repository.Add(entity);
        }

        public void DeleteAsync(Academic entity)
        {
            _repository.DeleteAsync(entity);
        }

        public Task<IEnumerable<Academic>> GetAllAsync()
        {
            var list = _repository.GetAllAsync();
            return list;
        }
    }
}