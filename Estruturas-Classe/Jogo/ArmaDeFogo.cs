using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    internal class ArmaDeFogo:Arma
    {
        public int Alcance { get; }

        public ArmaDeFogo(string nome, int alcance)
                    :base(nome)
        {
            this.Alcance = alcance;
            this.Dano = 5;
        }
    }
}
