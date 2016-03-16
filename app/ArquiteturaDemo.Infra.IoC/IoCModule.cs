using ArquiteturaDemo.Domain.Interfaces;
using ArquiteturaDemo.Infra.Repositories;
using ArquiteturaDemo.Infra.Repositories.EF;
using Ninject.Modules;

namespace ArquiteturaDemo.Infra.IoC
{
    public class IoCModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof (IRepositoryBase<>)).To(typeof (RepositoryBase<>));
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<ContextManager>().ToSelf();
        }
    }
}
