using System;

/*
Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é positivo ou negativo. Pare a execução do programa quando o usuário requisitar.
*/

namespace _21PositivoNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa PositivoNegativo--");

            int numero;

            do
            {
                Console.Write("\nDigite um número inteiro ou 0 para sair: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("O número é positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("O número é negativo.");
                }
                else
                {
                    Console.WriteLine("Zero digitado. Encerrando o programa...");
                    break;
                }
            } while (true);

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
