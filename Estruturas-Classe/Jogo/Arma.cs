using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    internal abstract class Arma: ItemInventario //Abstração (somente a classe Arma)
    {
        public string Nome { get; } //read only, ou seja, eu só posso pegar o valor do Nome da arma, eu não posso mudar o nome da arma
        public int Dano { get; set; }

        private static int contador = 0; //Estático -> compartilhado entre instâncias, pois ele não pertence a cada instância, ele pertence a Classe.

        public Arma(string nome)
        {
            contador++; //não é possível utilizar o this (não temos ref de instância)
            this.Nome = nome;
            Dano = 1;
        }

        public static int getContador()
        {
            return contador;
        }
    }
}
