using PasswordGenerator.Data.Repositiries;

namespace PasswordGenerator.Services.Service
{
    public class ServiceConstructor
    {
        protected IUnitOfWork _unitOfWork;
        protected ServiceConstructor(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }
    }
}
