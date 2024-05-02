using System;

namespace Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia 3 numeros inteiros e imprima a soma deles

            Console.WriteLine("--Bem vindo ao programa Soma--");
            Console.WriteLine();

            Console.Write("Digite o primeira número: ");
            int numeroUm = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numeroDois = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int numeroTres = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma dos número digitados é: {numeroUm + numeroDois + numeroTres}");

            Console.WriteLine();
            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
