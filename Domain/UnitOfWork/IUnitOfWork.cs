using System.Threading.Tasks;
using Domain.Repository;

namespace Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<TEntity> GetRepository<TEntity>(bool hasCustomRepository = false) where TEntity : class;
        void Dispose();
        void Save();
        Task SaveAsync();
    }
}