using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    internal class ArmaExplosiva
    {
        public double RaioDeExplosao { get; }

        public ArmaExplosiva (double raioExplosaoM2)
        {
            this.RaioDeExplosao = raioExplosaoM2;
        }
    }
}
