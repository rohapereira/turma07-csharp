using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Uma classe Habitacao com um atributo area e um construtor para atribuir o valor desse atributo. Cada habitação também terá uma porta (classe Porta). A habitação também terá um método Mostrar, que imprimirá na tela "Eu sou uma habitacao, minha area eh X m2, e a cor da minha porta é tal";

namespace Lista1Exercicio02
{
    public class Habitacao
    {
        // Atributos
        public int area;
        public Porta porta;

        // Construtor com parâmetros
        public Habitacao(int area, Porta porta)
        {
            this.area = area;
            this.porta = porta;
        }

        // Método Mostrar
        public void Mostrar()
        {
            Console.WriteLine($"Eu sou uma habitação, minha área é {this.area} m2, e a cor da minha porta é {this.porta.cor}.");
        }
    }
}
