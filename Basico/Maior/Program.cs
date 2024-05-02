using System;

//Faça um programa que leia 5 números inteiros informados pelo usuario e, no final, mostre o maior deles. Programa:Maior - usar o int.MinValue;

namespace Maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Maior--\n");

            #region "Solução sem o int.MinValue"
            //Console.Write("Digite o 1º número: ");
            //int numero = int.Parse(Console.ReadLine());

            //int maior = numero;
            //int menor = numero;

            //for (int i = 2; i <= 5; ++i)
            //{
            //    Console.Write($"Digite o {i}º número: ");
            //    numero = int.Parse(Console.ReadLine());

            //    if (numero > maior)
            //    {
            //        maior = numero;
            //    }
            //    else if (numero < menor)
            //    {
            //        menor = numero;
            //    }
            //}

            //Console.WriteLine($"O maior número é: {maior}");
            //Console.WriteLine($"O menor número é: {menor}");
            #endregion

            #region "Solução com int.MinValue"
            //int quantidadeNumeros = 5;
            //int maiorNumero = int.MinValue;

            //Console.WriteLine($"Digite {quantidadeNumeros} números inteiros:");

            //for (int i = 0; i < quantidadeNumeros; i++)
            //{
            //    Console.Write($"Número {i + 1}: ");
            //    int numero = int.Parse(Console.ReadLine());

            //    if (numero > maiorNumero)
            //    {
            //        maiorNumero = numero;
            //    }
            //}

            //Console.WriteLine($"O maior número digitado é: {maiorNumero}");
            #endregion

            #region "Solução do Jonatan Biancão"
            int quantidadeNumeros = 5;
            int maiorNumero = int.MinValue;

            Console.WriteLine($"Digite {quantidadeNumeros} números inteiros:");

            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.Write($"Número {i + 1}: ");
                bool sucesso = int.TryParse(Console.ReadLine(), out int numero);

                if (sucesso)
                {
                    if (numero > maiorNumero)
                        maiorNumero = numero;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    i--;
                }
            }

            Console.WriteLine($"O maior número digitado é: {maiorNumero}");
            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
