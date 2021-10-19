using AutoMapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DalDTO = BusinessLayer.DalDTO;

namespace BusinessLayer
{
    class DalMapperFactory
    {
        private static Mapper mapper;

        static DalMapperFactory()
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
                    cfg.CreateMap<DalDTO::Category, Category>()
                        .ForMember(entity => entity.Image, s => s.MapFrom(dto => dto.ImageLink));
                }); 

            mapper = new Mapper(config);
        }
    }
}
