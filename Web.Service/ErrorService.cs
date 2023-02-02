using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Data.Infrastructure;
using Web.Data.Repositories;
using Web.Model.Models;

namespace Web.Service
{
    public interface IErrorService
    {
        Error Create(Error error);
        void Save();
    }
    internal class ErrorService : IErrorService
    {
        IErrorRepository _errorRepository;
        IUnitOfWork _unitOfWork;
        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorRepository;
            this._unitOfWork = unitOfWork;
        }

        public Error Create(Error error)
        {
           return _errorRepository.Add(error);

        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
