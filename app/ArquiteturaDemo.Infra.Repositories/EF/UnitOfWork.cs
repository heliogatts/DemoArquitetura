using System.Data.Entity;
using ArquiteturaDemo.Domain.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace ArquiteturaDemo.Infra.Repositories.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;

        public void BeginTransaction()
        {
            var contextManager = ServiceLocator.Current.GetInstance<ContextManager>();

            _context = contextManager.Context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
