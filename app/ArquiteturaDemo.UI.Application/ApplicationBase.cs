using ArquiteturaDemo.Domain.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace ArquiteturaDemo.UI.Application
{
    public class ApplicationBase
    {
        private IUnitOfWork _unitOfWork;

        public void BeginTransaction()
        {
            _unitOfWork = ServiceLocator.Current.GetInstance<IUnitOfWork>();
            _unitOfWork.BeginTransaction();
        }

        public void Commit()
        {
            _unitOfWork.Commit();
        }
    }
}
