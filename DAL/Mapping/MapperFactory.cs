using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DalDTO = BusinessLayer.DalDTO;
using Models = DAL.Models;

namespace DAL.Mapping
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
                    cfg.CreateMap<Models::Category, DalDTO::Category>();
                });

            mapper = new Mapper(config);
        }
    }
}
