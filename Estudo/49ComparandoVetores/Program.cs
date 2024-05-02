using System;

//Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50). Determine e imprima quantas vezes que V1 e V2 possuem valores idênticos nas mesmas posições. 

namespace _49ComparandoVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ComparandoVetores--");

            const int TAMANHOMAXIMO = 4; //tamanho máximo de 50

            int[] v1 = new int[TAMANHOMAXIMO];
            int[] v2 = new int[TAMANHOMAXIMO];
            int correspondente = 0;

            Console.WriteLine("\nInsira os elementos do vetor V1:\n");
            LerVetor(v1);

            Console.WriteLine("\nInsira os elementos do vetor V2:\n");
            LerVetor(v2);

            for (int i = 0; i < TAMANHOMAXIMO; i++)
            {
                if (v1[i] == v2[i])
                {
                    correspondente++;
                }
            }

            Console.WriteLine($"\nNúmero de correspondências nas mesmas posições: {correspondente}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }

        // Método para ler os elementos de um vetor
        static void LerVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
