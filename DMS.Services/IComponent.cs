using DMS.Utilities;
using DMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Services
{
    public interface IComponent
    {
        PageResult<ComponentViewModel> GetAll(int pageNumber, int pageSize);
    }
}
