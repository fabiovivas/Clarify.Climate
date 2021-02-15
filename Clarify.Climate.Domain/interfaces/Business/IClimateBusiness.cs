using Clarify.Climate.Domain.Dto;
using System.Collections.Generic;

namespace Clarify.Climate.Domain.interfaces.Business
{
    public interface IClimateBusiness : IBusiness<PrevisaoClima>
    {
        TopClimate GetTopsClimate();
        List<PrevisaoClima> GetSevenClimateByCity(int cityId);
    }
}
