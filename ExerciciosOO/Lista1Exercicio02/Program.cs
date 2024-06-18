using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
2) Escreva um programa orientado a objetos com as seguintes características:

-Uma classe Porta com um atributo cor (string) e um método Mostrar que imprime na tela "Eu sou uma porta, minha cor é marrom" (ou qualquer cor que seja);
-Uma classe Habitacao com um atributo area e um construtor para atribuir o valor desse atributo. Cada habitação também terá uma porta (classe Porta). A habitação também terá um método Mostrar, que imprimirá na tela "Eu sou uma habitacao, minha area eh X m2, e a cor da minha porta é tal";
-Uma classe Apartamento é uma classe derivada da classe Habitacao, com area atribuída na instanciação igual a 50 m2
-Uma classe Morador derivada da classe Pessoa do exercício anterior, mas que possua uma habitação. Escreva também um método Mostrar que mostre as informações do morador e da habitação;
-Na classe principal, crie um apartamento, uma pessoa para morar nele, e mostre as informações.
*/

namespace Lista1Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Lista1Exercicio02--\n");

            Morador morador;

            morador = new Morador("William", 27, new Apartamento(new Porta("marrom")));
            morador.Mostrar();

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
