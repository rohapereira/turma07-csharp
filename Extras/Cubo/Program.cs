using System;

namespace Cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que o usuário digite um numero e ache o cubo desse numero

            Console.WriteLine("--Bem vindo ao programa Cubo--");
            Console.WriteLine();

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"O valor do número digitado elevado ao cubo é: {numero * numero * numero}");

            Console.WriteLine();
            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
