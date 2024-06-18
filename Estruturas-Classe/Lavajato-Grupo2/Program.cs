using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavajato_Grupo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro(1, "carro1", "hatch");
            Carro carro2 = new Carro(2, "carro2", "SUV");
            Carro carro3 = new Carro(3, "carro3", "sedan");

            LavaJato lavaJato = new LavaJato();

            lavaJato.AdicionarFila(carro1);
            lavaJato.AdicionarFila(carro2);
            lavaJato.AdicionarFila(carro3);

            lavaJato.RemoverFila();
            lavaJato.RemoverFila();
            lavaJato.RemoverFila();

            lavaJato.GetPatio();

            Console.ReadLine();
        }
    }
}
