using UnitOfWorkPrincipleInNetCoreWebAPI.Core.Model;

namespace UnitOfWorkPrincipleInNetCoreWebAPI.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
        Task<int> Complete();
    }
}
