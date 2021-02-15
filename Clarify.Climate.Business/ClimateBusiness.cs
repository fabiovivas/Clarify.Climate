using Clarify.Climate.Domain;
using Clarify.Climate.Domain.Dto;
using Clarify.Climate.Domain.interfaces.Business;
using Clarify.Climate.Domain.interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clarify.Climate.Business
{
    public class ClimateBusiness : BusinessBase<PrevisaoClima>, IClimateBusiness
    {
        private readonly IRepository<PrevisaoClima> climateRepo;
        public ClimateBusiness(IRepository<PrevisaoClima> climateRepo) : base(climateRepo)
        {
            this.climateRepo = climateRepo;
        }

        public TopClimate GetTopsClimate()
        {
            var today = DateTime.Now;
            var climate = climateRepo.Filter(c => c.DataPrevisao == today.Date,
                new string[] { "Cidade.Estado" });

            var topClimate = new TopClimate();
            topClimate.Top3Max = (from c in climate
                                  orderby c.TemperaturaMaxima descending, c.Cidade.Nome, c.Cidade.Estado.Nome
                                  select c).Take(3).ToList();

            topClimate.Top3Min = (from c in climate
                                  orderby c.TemperaturaMaxima, c.Cidade.Nome, c.Cidade.Estado.Nome
                                  select c).Take(3).ToList();
            return topClimate;
        }

        public List<PrevisaoClima> GetSevenClimateByCity(int cityId)
        {
            var today = DateTime.Now;
            var finalDate = today.AddDays(7);
            var climate = climateRepo.Filter(c => c.Cidade.Id == cityId &&
               (c.DataPrevisao > today && c.DataPrevisao < finalDate.Date),
               new string[] { "Cidade.Estado" });

            return climate;
        }
    }
}
