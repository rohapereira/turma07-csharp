using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Uma classe Morador derivada da classe Pessoa do exercício anterior, mas que possua uma habitação. Escreva também um método Mostrar que mostre as informações do morador e da habitação;

namespace Lista1Exercicio02
{
    public class Morador : Pessoa
    {
        // Atributo do tipo Habitacao
        public Habitacao habitacao;

        // Construtor com parâmetros herdados da classe Pessoa e que instancia uma habitacao
        public Morador(string nome, int idade, Habitacao habitacao) : base(nome, idade)
        {
            this.habitacao = habitacao;
        }

        // Método Mostrar
        public void Mostrar()
        {
            Console.WriteLine($"Sou um morador, meu nome é {this.nome}, tenho {this.idade} anos, minha habitação tem {this.habitacao.area} m2, e a cor da porta é {this.habitacao.porta.cor}.");
        }
    }
}
