using System.Collections.Generic;

namespace Clarify.Climate.Domain
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual List<PrevisaoClima> PrevisaoClimaList { get; set; }
        public Cidade()
        {
            PrevisaoClimaList = new List<PrevisaoClima>();
        }
    }
}
