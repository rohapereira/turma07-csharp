using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lista1Exercicio06
{
    public class Filmes : Media
    {
        // Propriedades
        public string Diretor { get; set; }
        public string AtorPrincipal { get; set; }
        public string AtrizPrincipal { get; set; }

        // Método Play
        public override void Reproduzir()
        {
            Console.WriteLine($"Assistindo o filme: {Nome}");
        }

        // Método RetrieveInformation
        public override void RecuperarInformacao()
        {
            Console.WriteLine($"Mostrando informações do filme: {Nome}");
        }
    }
}
