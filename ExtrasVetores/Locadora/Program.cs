using System;
using System.Collections.Generic;

//Uma locadora de vídeos tem guardada, em um vetor de 50 posições, a quantidade de filmes retirados por seus clientes durante o ano de 2012. Agora, esta locadora está fazendo uma promoção e, para cada 10 filmes retirados, o cliente tem direito a uma locação grátis. Faça um programa que crie um outro vetor contendo a quantidade de locações gratuitas a que cada cliente tem direito.

namespace Locadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa NumerosPrimos--");

            #region "Solução usando Array"
            //const int tamanhoVetor = 5; //50
            //const int filmesPorLocacaoGratis = 10;

            //// Vetor contendo a quantidade de filmes retirados por cada cliente
            //int[] filmesRetirados = new int[tamanhoVetor];

            //// Vetor para armazenar a quantidade de locações gratuitas para cada cliente
            //int[] locacoesGratuitas = new int[tamanhoVetor];

            //// Ler a quantidade de filmes retirados por cada cliente
            //for (int i = 0; i < tamanhoVetor; i++)
            //{
            //    Console.Write($"Quantidade de filmes retirados pelo cliente {i + 1}: ");
            //    filmesRetirados[i] = int.Parse(Console.ReadLine());
            //}

            //// Calcular a quantidade de locações gratuitas para cada cliente
            //for (int i = 0; i < tamanhoVetor; i++)
            //{
            //    locacoesGratuitas[i] = filmesRetirados[i] / filmesPorLocacaoGratis;
            //}

            //// Exibir a quantidade de locações gratuitas para cada cliente
            //Console.WriteLine("\nQuantidade de locações gratuitas para cada cliente:");
            //for (int i = 0; i < tamanhoVetor; i++)
            //{
            //    Console.WriteLine($"Cliente {i + 1}: {locacoesGratuitas[i]}");
            //}
            #endregion

            #region "Solução usando List"
            const int tamanhoVetor = 5; //50
            const int filmesPorLocacaoGratis = 10;

            // Lista contendo a quantidade de filmes retirados por cada cliente
            List<int> filmesRetirados = new List<int>(tamanhoVetor);

            // Lista para armazenar a quantidade de locações gratuitas para cada cliente
            List<int> locacoesGratuitas = new List<int>(tamanhoVetor);

            // Ler a quantidade de filmes retirados por cada cliente
            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.Write($"Quantidade de filmes retirados pelo cliente {i + 1}: ");
                filmesRetirados.Add(int.Parse(Console.ReadLine()));
            }

            // Calcular a quantidade de locações gratuitas para cada cliente
            for (int i = 0; i < tamanhoVetor; i++)
            {
                locacoesGratuitas.Add(filmesRetirados[i] / filmesPorLocacaoGratis);
            }

            // Exibir a quantidade de locações gratuitas para cada cliente
            Console.WriteLine("\nQuantidade de locações gratuitas para cada cliente:");
            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.WriteLine($"Cliente {i + 1}: {locacoesGratuitas[i]}");
            }
            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
