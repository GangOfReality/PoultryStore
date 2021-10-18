using AutoMapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApiDTO = BusinessLayer.ApiDTO;

namespace BusinessLayer.Mapping
{
    static class ApiMapperFactory
    {
        private static Mapper mapper;

        static ApiMapperFactory()
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
                    cfg.CreateMap<Category, ApiDTO::Category>()
                        .ForMember(dto => dto.ImageLink, s => s.MapFrom(entity => entity.Image));
                });

            mapper = new Mapper(config);
        }
    }
}
