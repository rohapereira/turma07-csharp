using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lista1Exercicio06
{
    public class Musicas : Media
    {
        // Propriedades
        public string Artista { get; set; }
        public int DuracaoEmSegundos { get; set; }

        // Método Play
        public override void Reproduzir()
        {
            Console.WriteLine($"Tocando música: {Nome}");
        }

        // Método RetrieveInformation
        public override void RecuperarInformacao()
        {
            Console.WriteLine($"Mostrando informações da música: {Nome}");
        }
    }
}
