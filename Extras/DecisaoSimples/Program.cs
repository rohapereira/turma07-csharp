using System;

namespace DecisaoSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia um numero inteiro. Se o numero for maior ou igual a 100 emitir uma mensagem dizendo "Número maior ou igual a 100". Caso contrario escreva "Número menor que 100".

            Console.WriteLine("--Bem vindo ao programa DecisaoSimples--");
            Console.WriteLine();

            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 100)
                Console.WriteLine("Número maior ou igual a 100");
            else
                Console.WriteLine("Número menor que 100");

            Console.WriteLine();
            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
