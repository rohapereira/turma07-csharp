using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueDiversao
{
    internal class TremFantasma : BrinquedoEletrico, IBrinquedoAssustador
    {
        public TremFantasma()
        {
            this.Nome = "Trem Fantasma Assustador";
        }
        public int NivelMedo { get; set; }

        public void assustar()
        {
            this.NivelMedo = 15;
        }
    }
}
