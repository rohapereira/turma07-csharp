using System;

/*
Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor fornecido está na faixa 
entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”. 
Caso contrário, apresentar a mensagem “valor inválido”. 
*/

namespace _17FaixaDeValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo do programa FaixaDeValor--");

            Console.Write("\nDigite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 9)
            {
                Console.WriteLine("\nValor válido!");
            }
            else
            {
                Console.WriteLine("\nValor inválido!");
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
