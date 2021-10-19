using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ApiDTO = BusinessLayer.ApiDTO;
using WebDTO = API.WebDTO;

namespace API.Mapping
{
    public static class MapperFactory
    {
        private static Mapper mapper;

        static MapperFactory()
        {
            ConfigureMapper();
        }

        public static Mapper GetMapper()
        {
            return mapper;
        }

        private static void ConfigureMapper()
        {
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<ApiDTO::Category, WebDTO::Category>();
                });

            mapper = new Mapper(config);
        }
    }
}
