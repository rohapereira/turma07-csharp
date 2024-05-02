using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    internal class ArmaDeFogo:Arma
    {
        public int Alcance { get; }

        public ArmaDeFogo(int alcance)
        {
            this.Alcance = alcance;
        }
    }
}
