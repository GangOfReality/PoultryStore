using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BusinessLayer.Interfaces;
using BusinessLayer.CustomerUseCases;
using WebDTO = API.WebDTO;
using AutoMapper;
using API.Mapping;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        IWatchCatalogUseCase watchCatalogUseCase;
        Mapper mapper;

        public CategoryController(IWatchCatalogUseCase watchCatalogUseCase)
        {
            this.watchCatalogUseCase = watchCatalogUseCase;
            mapper = MapperFactory.GetMapper();
        }


        // GET: <CategoryController>
        [HttpGet]
        public IEnumerable<WebDTO::Category> Get()
        {
            var categories = watchCatalogUseCase.GetCategories();
            return mapper.Map<IEnumerable<WebDTO::Category>>(categories);
        }

        //// GET <CategoryController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST <CategoryController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT <CategoryController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE <CategoryController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
