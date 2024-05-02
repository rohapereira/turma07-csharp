using System;

/*
Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que a variável A passe a 
possuir o valor da variável B, e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.
*/

namespace TrocaNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa TrocaNumeros--");

            Console.Write("\nDigite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.Write("\nExibe os valores trocados: ");
            Console.Write($"\nA = {a}");
            Console.WriteLine($"\nB = {b}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
