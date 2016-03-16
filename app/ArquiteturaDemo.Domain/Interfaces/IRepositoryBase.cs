using System.Collections.Generic;

namespace ArquiteturaDemo.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(TEntity entity );
        void Delete(int id);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
    }
}
