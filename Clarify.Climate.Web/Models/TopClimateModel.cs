using Clarify.Climate.Domain;
using System.Collections.Generic;

namespace Clarify.Climate.Web.Models
{
    public class TopClimateModel
    {
        public List<PrevisaoClima> Top3Max { get; set; }
        public List<PrevisaoClima> Top3Min { get; set; }
    }
}