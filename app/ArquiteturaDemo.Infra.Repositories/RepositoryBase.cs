using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using ArquiteturaDemo.Domain.Interfaces;
using ArquiteturaDemo.Infra.Repositories.EF;
using Microsoft.Practices.ServiceLocation;

namespace ArquiteturaDemo.Infra.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected DbContext Context { get; private set; }
        //protected ArquiteturaContext Context { get; private set; }

        public RepositoryBase()
        {
            var contextManager =  ServiceLocator.Current.GetInstance<ContextManager>();
            Context = contextManager.Context;
        }
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void Delete(int id)
        {
            var obj = Get(id);
            Delete(obj);
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }
    }
}