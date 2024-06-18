using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Uma classe Porta com um atributo cor (string) e um método Mostrar que imprime na tela "Eu sou uma porta, minha cor é marrom" (ou qualquer cor que seja);

namespace Lista1Exercicio02
{
    public class Porta
    {
        // Atributos
        public string cor;

        // Construtor com parâmetros
        public Porta(string cor)
        {
            this.cor = cor;
        }

        // Método Mostrar
        public void Mostrar()
        {
            Console.WriteLine($"Eu sou uma porta, minha cor é {this.cor}.");
        }
    }
}
