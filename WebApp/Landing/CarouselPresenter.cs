using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.ApiClients;
using AutoMapper;
using System.Net.Http;

namespace WebApp.Landing
{
    public class CarouselPresenter
    {
        private readonly CategoryClient categoryClient;
        private CarouselViewModel viewModel;
        private Mapper mapper;

        public CarouselPresenter()
        {
            categoryClient = new CategoryClient();
            viewModel = new CarouselViewModel();
            ConfigureMapper();
        }

        public async Task<CarouselViewModel> InitAndGetViewModel()
        {
            await UpdateCategories();
            return viewModel;
        }

        public async Task UpdateCategories()
        {
            try
            {
                var categories = await categoryClient.ReceiveAllCategories();
                MapCategoriesToViewModel(categories);
            }
            catch (HttpRequestException)
            { 
                //TODO: add logs.
            }
        }

        private void MapCategoriesToViewModel(List<CategoryDTO> dtoList)
        {
            var categoryes = mapper.Map<List<CategoryDTO>, List<CarouselItemViewModel>>(dtoList);
            viewModel.CarouselItems = categoryes;
        }

        private void ConfigureMapper()
        {
            var config = new MapperConfiguration(
                cfg => 
                {
                    cfg.CreateMap<CategoryDTO, CarouselItemViewModel>();
                    //To map another DTO to his ViewModel - just add new map.
                });

            mapper = new Mapper(config);
        }
    }
}
