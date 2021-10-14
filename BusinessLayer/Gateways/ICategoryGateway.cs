using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DalDTO = BusinessLayer.DalDTO;

namespace BusinessLayer.Gateways
{
    interface ICategoryGateway
    {
        IEnumerable<DalDTO::Category> RetrieveAllCategories();
    }
}
