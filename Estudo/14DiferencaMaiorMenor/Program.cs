using System;

/*
 Escreva um programa que leia dois números e apresente a diferença do maior para o menor.
*/

namespace _14DiferencaMaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa DiferencaMaiorMenor--");

            Console.Write("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDiferença entre o maior e menor número digitado: ");
            int maior, menor, diferenca;

            if (numero1 == numero2)
            {
                maior = numero1;
                menor = numero2;
                diferenca = numero1 - numero2;

                Console.WriteLine($"{numero1} - {numero2} = {diferenca}");
            }
            else if (numero1 > numero2)
            {
                maior = numero1;
                menor = numero2;
                diferenca = numero1 - numero2;

                Console.WriteLine($"{numero1} - {numero2} = {diferenca}");
            }
            else
            {
                maior = numero2;
                menor = numero1;
                diferenca = numero2 - numero1;

                Console.WriteLine($"{numero2} - {numero1} = {diferenca}");
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
