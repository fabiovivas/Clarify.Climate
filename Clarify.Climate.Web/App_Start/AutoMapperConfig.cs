using AutoMapper;
using Clarify.Climate.Domain;
using Clarify.Climate.Domain.Dto;
using Clarify.Climate.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clarify.Climate.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }
        public static void RegisterMappings()
        {
            var config = new MapperConfiguration(mapper =>
            {
                mapper.CreateMap<TopClimate, TopClimateModel>().MaxDepth(2).ReverseMap();
                mapper.CreateMap<PrevisaoClima, PrevisaoClimaModel>().MaxDepth(2).ReverseMap();
            });
            Mapper = config.CreateMapper();
        }
    }
}