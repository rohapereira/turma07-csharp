using System;

//Fazer um programa para armazenar em um vetor, vários números inteiros e positivos e calcular a média. Imprimir também o maior. A quantidade de números lidos será definida pelo usuário.

namespace _58LerVetorEFazerCalculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa LerVetorEFazerCalculos--");

            Console.Write("\nQuantos números você deseja inserir? ");
            int quantidade = int.Parse(Console.ReadLine());

            int[] numeros = new int[quantidade];
            int soma = 0;
            int maior = int.MinValue;

            Console.WriteLine("\nInsira os números: ");

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Número {i+1}: ");
                numeros[i] = int.Parse(Console.ReadLine());

                soma += numeros[i];
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            double media = (double)soma / quantidade;

            Console.WriteLine($"\nA média dos números é {media:0.00}");
            Console.WriteLine($"O maior número é {maior}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
