using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    internal sealed class ArmaExplosiva:ArmaDeFogo
    {
        public double RaioDeExplosao { get; }

        public ArmaExplosiva (string nome, int alcance, double raioExplosaoM2)
                        :base(nome, alcance)
        {
            this.RaioDeExplosao = raioExplosaoM2;
        }
    }
}
