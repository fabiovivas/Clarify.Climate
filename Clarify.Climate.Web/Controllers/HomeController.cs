using AutoMapper;
using Clarify.Climate.Domain;
using Clarify.Climate.Domain.Dto;
using Clarify.Climate.Domain.interfaces.Business;
using Clarify.Climate.Web.App_Start;
using Clarify.Climate.Web.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Clarify.Climate.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClimateBusiness climateBusiness;
        private readonly IBusiness<Cidade> cidadeBusiness;
        private readonly IMapper mapper;

        public HomeController(IClimateBusiness climateBusiness, IBusiness<Cidade> cidadeBusiness)
        {
            this.climateBusiness = climateBusiness;
            this.cidadeBusiness = cidadeBusiness;
            this.mapper = AutoMapperConfig.Mapper;
        }
        public ActionResult Index()
        {
            var climate = climateBusiness.GetTopsClimate();
            var climateModel = mapper.Map<TopClimateModel>(climate);
            ViewBag.City = new SelectList(cidadeBusiness.Filter(c => 1 == 1, new string[] { "Estado" }), "Id", "Nome", "Estado.Nome", 0);
            return View(climateModel);
        }

        public ActionResult LoadCityClimate(int id)
        {
            var climate = climateBusiness.GetSevenClimateByCity(id);
            var climateModel = mapper.Map<IEnumerable<PrevisaoClimaModel>>(climate);
            return PartialView("_PartialResultSearch", climateModel);
        }
    }
}