using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clarify.Climate.Domain.Dto
{
    public class TopClimate
    {
        public List<PrevisaoClima> Top3Max { get; set; }
        public List<PrevisaoClima> Top3Min { get; set; }
    }
}
