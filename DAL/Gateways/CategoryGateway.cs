using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.DalDTO;
using BusinessLayer.Gateways;
using DAL.Mapping;
using DAL.Repositories;

namespace DAL.Gateways
{
    public class CategoryGateway : ICategoryGateway
    {
        private CategoryRepository categoryRepository;
        private Mapper mapper;

        public CategoryGateway()
        {
            mapper = MapperFactory.GetMapper();
        }

        public IEnumerable<Category> RetrieveAllCategories()
        {
            var models = categoryRepository.GetAllCategoryes();
            return mapper.Map<List<Category>>(models);
        }
    }
}
