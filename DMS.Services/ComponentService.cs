using DMS.Repositories.Interfaces;
using DMS.Utilities;
using DMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Services
{
    public class ComponentService : IComponent
    {
        private IUnitOfWork _unitOfWork;

        public ComponentService(IUnitOfWork unitOfWork) 
        { 
            _unitOfWork = unitOfWork;
        }

        public PageResult<ComponentViewModel> GetAll(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
