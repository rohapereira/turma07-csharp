using System;

/*
Escreva um programa que deverá ter as seguintes opções:
1 - Carregar Vetor 
2 - Listar Vetor 
3 - Exibir apenas os números pares do vetor 
4 - Exibir apenas os números ímpares do vetor 
5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor 
6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor 
7 - Sair 
Deverá ser implementado um método para realizar cada uma das opções de 1 a 6.
*/

namespace _64MetodosOpcoesVetor
{
    internal class Program
    {
        static int[] vetor = new int[0];
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MetodosopcoesVetor--");

            int opcao;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Carregar Vetor");
                Console.WriteLine("2 - Listar Vetor");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
                Console.WriteLine("5 - Exibir a quantidade de números pares que existem nas posições ímpares do vetor");
                Console.WriteLine("6 - Exibir a quantidade de números ímpares que existem nas posições pares do vetor");
                Console.WriteLine("7 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CarregarVetor();
                        break;
                    case 2:
                        ListarVetor();
                        break;
                    case 3:
                        ExibirNumerosPares();
                        break;
                    case 4:
                        ExibirNumerosImpares();
                        break;
                    case 5:
                        QuantidadeParesPosicoesImpares();
                        break;
                    case 6:
                        QuantidadeImparesPosicoesPares();
                        break;
                    case 7:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;
                }
            } while (opcao != 7);

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
        static void CarregarVetor()
        {
            Console.Write("\nDigite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());
            vetor = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o elemento {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        static void ListarVetor()
        {
            Console.WriteLine("\nVetor: ");
            foreach (int num in vetor)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void ExibirNumerosPares()
        {
            Console.WriteLine("\nNúmeros pares no vetor:");
            foreach (int num in vetor)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }
        static void ExibirNumerosImpares()
        {
            Console.WriteLine("\nNúmeros ímpares no vetor:");
            foreach (int num in vetor)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }
        static void QuantidadeParesPosicoesImpares()
        {
            int count = 0;
            for (int i = 1; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"\nQuantidade de números pares nas posições ímpares: {count}");
        }
        static void QuantidadeImparesPosicoesPares()
        {
            int count = 0;
            for (int i = 0; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"\nQuantidade de números ímpares nas posições pares: {count}");
        }
    }
}
