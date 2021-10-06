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
        private CategoryClient categoryClient;
        private CarouselViewModel viewModel;

        public CarouselPresenter()
        {
            categoryClient = new CategoryClient();
            viewModel = new CarouselViewModel();
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
            var config = new MapperConfiguration(
                cfg => cfg.CreateMap<CategoryDTO, CarouselItemViewModel>());

            var mapper = new Mapper(config);
            var categoryes = mapper.Map<List<CategoryDTO>, List<CarouselItemViewModel>>(dtoList);

            viewModel.CarouselItems = categoryes;
        }
    }
}
