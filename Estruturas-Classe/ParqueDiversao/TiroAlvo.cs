using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueDiversao
{
    internal sealed class TiroAlvo : BrinquedoNaoEletrico, IBrinquedoAssustador
    {
        public TiroAlvo()
        {
            this.Nome = "Tiro ao alvo";
        }

        public int NivelMedo { get; set; }

        public void assustar()
        {
            this.NivelMedo = 5;
        }
    }
}
