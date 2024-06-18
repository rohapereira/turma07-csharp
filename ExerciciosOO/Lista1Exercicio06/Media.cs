using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Exercicio06
{
    // Classe base
    public abstract class Media
    {
        // Propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double TamanhoArquivo { get; set; }

        // Método Play (ainda não implementado)
        public abstract void Reproduzir();

        // Método RetrieveInformation (ainda não implementado)
        public abstract void RecuperarInformacao();
    }
}
