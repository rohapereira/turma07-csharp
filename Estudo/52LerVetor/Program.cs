using System;

// Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas vezes aparece o número 1, 3 e 4, nesta ordem.O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1. 

namespace _52LerVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa LerVetor--");

            const int TAMANHOMAXIMO = 100;
            int[] vetor = new int[TAMANHOMAXIMO];
            int tamanho = 0;

            Console.WriteLine("\nDigite os números inteiros positivos (ou -1 para sair): \n");

            for (int i = 0; i < TAMANHOMAXIMO; i++)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero == -1)
                    break;
                else if (numero > 0)
                {
                    vetor[i] = numero;
                    tamanho++;
                }
                else
                {
                    Console.WriteLine("Digite apenas números positivos ou -1 para sair.");
                    i--;
                }
            }

            // Contagem das ocorrências dos números 1, 3 e 4
            int contagem1 = 0, contagem3 = 0, contagem4 = 0;
            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] == 1)
                    contagem1++;
                else if (vetor[i] == 3)
                    contagem3++;
                else if (vetor[i] == 4)
                    contagem4++;
            }

            Console.Write($"\nNúmero 1 aparece {contagem1} vezes.\n");
            Console.Write($"Número 3 aparece {contagem3} vezes.\n");
            Console.WriteLine($"Número 4 aparece {contagem4} vezes.");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
