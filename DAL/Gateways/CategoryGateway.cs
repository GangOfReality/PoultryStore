using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLayer.DalDTO;
using BusinessLayer.Gateways;
using DAL.Repositories;

namespace DAL.Gateways
{
    class CategoryGateway : ICategoryGateway
    {
        CategoryRepository categoryRepository;

        public IEnumerable<Category> RetrieveAllCategories()
        {
            var models = categoryRepository.GetAllCategoryes();

            //TODO: map models to DTO.
            //TODO: return DTO.

            throw new NotImplementedException();
        }
    }
}
