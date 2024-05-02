using System;

/*
Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza. Foram inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade. Tais informações foram armazenadas em 2 vetores distintos. Faça um programa para imprima o vetor que contém os nomes das candidatas aptas a concorrer a uma vaga para a campanha milionária.
*/

namespace _48AgenciaDePublicidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa AgenciaDePublicidade--\n");

            const int TAMANHOVETOR = 5; //vai ser 20

            string[] nomes = new string[TAMANHOVETOR];
            int[] idades = new int[TAMANHOVETOR];

            for (int i = 0; i < TAMANHOVETOR; i++)
            {
                Console.Write($"Insira o nome da candidata {i + 1}: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Insira a idade da candidata {i + 1}: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nCandidatas aptas para a campanha milionária: \n");

            for (int i = 0; i < TAMANHOVETOR; i++)
            {
                if (idades[i] >= 18 && idades[i] <= 20)
                {
                    Console.WriteLine(nomes[i]);
                }
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
