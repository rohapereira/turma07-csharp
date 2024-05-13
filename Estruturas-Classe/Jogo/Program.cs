using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArmaBranca faca = new ArmaBranca("Faca");

            //ArmaDeFogo pistola = new ArmaDeFogo("PistolaX", 50);

            ArmaDeFogo metralhadora = new ArmaDeFogo("P90", 150);
            metralhadora.Dano = 35;

            ArmaExplosiva bomba = new ArmaExplosiva("Dinamite", 5, 3);

            Console.WriteLine(Arma.getContador());

            Personagens p1 = new Personagens();

            p1.Nome = "Persona1";
            p1.Time = "Vilão";
            p1.adicionarItemInventario(faca);
            p1.adicionarItemInventario(metralhadora);
        }
    }
}
