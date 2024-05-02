using System;

//Dada uma sequência de n números (vetor de inteiros), imprimi-la na ordem inversa que foi realizada a leitura.

namespace _45VetorOrdemInversa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa VetorOrdemInversa--");

            Console.Write("\nQual o tamanho da sequência que deseja digitar? ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] sequencia = new int[tamanho];

            Console.WriteLine();

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                sequencia[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            //Imprimir na ordem inversa
            for (int i = tamanho - 1; i >= 0; i--)
            {
                Console.WriteLine(sequencia[i]);
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
