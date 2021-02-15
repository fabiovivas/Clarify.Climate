using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clarify.Climate.Web.Models
{
    public class PrevisaoClimaModel
    {
        public DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public decimal TemperaturaMinima { get; set; }
        public decimal TemperaturaMaxima { get; set; }
    }
}