using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

using Entities;
using BusinessLayer.Gateways;
using BusinessLayer.Interfaces;
using BusinessLayer.Mapping;
using ApiDTO = BusinessLayer.ApiDTO;
using DalDTO = BusinessLayer.DalDTO;

namespace BusinessLayer.CustomerUseCases
{
    public class WatchCatalogUseCase : IWatchCatalogUseCase
    {
        private ICategoryGateway categoryGateway;
        private Mapper apiMapper;
        private Mapper dalMapper;

        public WatchCatalogUseCase()
        {
            apiMapper = ApiMapperFactory.GetMapper();
            dalMapper = DalMapperFactory.GetMapper();
        }

        public IEnumerable<ApiDTO::Category> GetCategories()
        {
            //var categoryesDalDTO = categoryGateway.RetrieveAllCategories();
            //var categoryes = dalMapper.Map<IEnumerable<Category>>(categoryesDalDTO);

            //TODO: It's mock, need replace on gateway call. 
            List<Category> categoryes = new()
            {
                new() { Name = "Бройлеры", Image = "img/cart-broyler.jpg" },
                new() { Name = "Несушки", Image = "img/cart-nesushka.jpg" },
                new() { Name = "Яйца", Image = "img/gallery6.jpg" }
            };

            return apiMapper.Map<IEnumerable<ApiDTO::Category>>(categoryes);
        }

        public IEnumerable<ApiDTO::Product> GetProductsByCategoryId(Guid categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
