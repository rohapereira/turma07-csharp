using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    internal class Arma
    {
        public string Nome { get; } //read only, ou seja, eu só posso pegar o valor do Nome da arma, eu não posso mudar o nome da arma
        public int Dano { get; set; }

        public Arma(string nome)
        {
            this.Nome = nome;
            Dano = 1;
        }
    }
}
