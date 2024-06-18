using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueDiversao
{
    internal sealed class Carrossel : BrinquedoEletrico
    {
        public Carrossel()
        {
            this.Nome = "Carrosel";
            this.idadeMinima = 0;
        }
    }
}
