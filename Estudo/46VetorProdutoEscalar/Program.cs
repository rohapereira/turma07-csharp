using System;

//Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar desses vetores. Ou seja, realizar a soma de todos dos resultados da multiplicação de x[i] por y[i]. 

namespace _46VetorProdutoEscalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa VetorProdutoEscalar--");

            Console.Write("\nDigite o tamanho dos vetores: ");
            int n = int.Parse(Console.ReadLine());

            int[] vetorX = new int[n];
            int[] vetorY = new int[n];

            Console.WriteLine("\nDigite os elementos do vetor X:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetorX[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDigite os elementos do vetor Y:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetorY[i] = int.Parse(Console.ReadLine());
            }

            // Cálculo do produto escalar
            int produtoEscalar = 0;
            for (int i = 0; i < n; i++)
            {
                produtoEscalar += vetorX[i] * vetorY[i];
            }

            Console.WriteLine($"\nO produto escalar dos vetores X e Y é: {produtoEscalar}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
