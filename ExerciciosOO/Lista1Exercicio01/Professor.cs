using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Uma classe Professor derivada da classe Pessoa, com um método Explicar que recebe como parâmetro um assunto;

namespace Lista1Exercicio01
{
    public class Professor : Pessoa
    {
        // Construtor vazio
        public Professor()
        {
        }

        // Construtor com parâmetros herdados da classe Pessoa
        public Professor(string pNome, int pIdade) : base(pNome, pIdade)
        {
        }

        // Método explicar
        public void Explicar(string assunto)
        {
            Console.WriteLine($"O professor {this.nome} está explicando sobre {assunto}.");
        }
    }
}
