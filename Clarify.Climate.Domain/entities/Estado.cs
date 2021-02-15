using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clarify.Climate.Domain
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public virtual List<Cidade> CidadeList { get; set; }

        public Estado()
        {
            CidadeList = new List<Cidade>();
        }
    }
}
