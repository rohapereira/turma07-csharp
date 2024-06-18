using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueDiversao
{
    internal class MontanhaRussa : BrinquedoEletrico, IBrinquedoAssustador, IBrinquedoRadical
    {
        public double AlturaMinima { get; }
        public int NivelMedo { get; set; }
        public int NivelAdrenalina { get; set; }

        public MontanhaRussa()
        {
            this.Nome = "Montanha Russa";
            this.AlturaMinima = 1.5;

            this.idadeMinima = 10;
        }

        public void assustar()
        {
            this.NivelMedo = 10;
        }
    }
}
