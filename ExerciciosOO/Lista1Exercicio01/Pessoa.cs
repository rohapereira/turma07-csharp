using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Uma classe Pessoa, com atributos nome e idade, e métodos Cumprimentar e DizerIdade;

namespace Lista1Exercicio01
{
    public class Pessoa
    {
        // Atributos
        public string nome;
        public int idade;

        // Construtor vazio
        public Pessoa()
        {
        }

        // Construtor com parâmetros
        public Pessoa(string pnome, int pidade)
        {
            this.nome = pnome;
            this.idade = pidade;
        }

        // Método cumprimentar
        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, meu nome é {this.nome}.");
        }

        // Método dizer idade
        public void DizerIdade()
        {
            Console.WriteLine($"Tenho {this.idade} anos de idade.");
        }
    }
}
