using System;

/*
Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.
*/

namespace _13OrdemDecrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa OrdemDecrescente--");

            Console.Write("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int numero3 = int.Parse(Console.ReadLine());

            int maior, meio, menor;

            if (numero1 >= numero2 && numero1 >= numero3)
            {
                maior = numero1;
                meio = (numero2 >= numero3) ? numero2 : numero3;
                menor = (numero2 < numero3) ? numero2 : numero3;
            }
            else if (numero2 >= numero1 && numero2 >= numero3)
            {
                maior = numero2;
                meio = (numero1 >= numero3) ? numero1 : numero3;
                menor = (numero1 < numero3) ? numero1 : numero3;
            }
            else
            {
                maior = numero3;
                meio = (numero1 >= numero2) ? numero1 : numero2;
                menor = (numero1 < numero2) ? numero1 : numero2;
            }

            Console.WriteLine("\nOs números em ordem decrescente são:");
            Console.WriteLine(maior);
            Console.WriteLine(meio);
            Console.WriteLine(menor);

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
