using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

using Entities;
using BusinessLayer.Gateways;
using BusinessLayer.Interfaces;
using ApiDTO = BusinessLayer.ApiDTO;
using DalDTO = BusinessLayer.DalDTO;

namespace BusinessLayer.CustomerUseCases
{
    class WatchCatalogUseCase : IWatchCatalogUseCase
    {
        private ICategoryGateway categoryGateway;
        private Mapper apiMapper;
        private Mapper dalMapper;

        public WatchCatalogUseCase()
        {
            ConfigureApiMapper();
            ConfigureDalMapper();
        }

        public IEnumerable<ApiDTO::Category> GetCategories()
        {
            var categoryesDalDTO = categoryGateway.RetrieveAllCategories();
            var categoryes = dalMapper.Map<IEnumerable<DalDTO::Category>, IEnumerable<Category>>(categoryesDalDTO);

            var categoryesApiDTO = apiMapper.Map<IEnumerable<Category>, IEnumerable<ApiDTO::Category>>(categoryes);
            return categoryesApiDTO;
        }

        public IEnumerable<ApiDTO::Product> GetProductsByCategoryId(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        private void ConfigureApiMapper()
        {
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<ApiDTO::Category, ICategory>();
                });

            apiMapper = new Mapper(config);
        }

        private void ConfigureDalMapper()
        {
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<DalDTO::Category, ICategory>();
                });

            dalMapper = new Mapper(config);
        }
    }
}
