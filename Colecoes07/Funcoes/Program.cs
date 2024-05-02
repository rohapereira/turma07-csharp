using System;

namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Início--");

            Console.WriteLine("Digite um número a ser somado ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número a ser somado ");
            int numero2 = int.Parse(Console.ReadLine());

            int soma = Somar(numero1, numero2);

            Console.WriteLine($"O valor da soma é: {soma}");

            PularLinha(); //A ação de uma função dentro do main é chamada "Invocar";

            Console.WriteLine("--Meio--");

            Console.WriteLine("Quer pular quantas linhas por gentileza? ");
            int pularlinhas = int.Parse(Console.ReadLine());

            PularLinhas(pularlinhas);
            //PularLinha(10);

            Console.WriteLine("--Fim--");

            Console.WriteLine("Digite ENTER para sair");
            Console.ReadLine();
        }

        static void PularLinha()
        {
            for (int i = 0; i < 1; i++)
                Console.WriteLine();
        }
        static void PularLinhas(int linhasParaPular)
        {
            for (int i = 0; i < linhasParaPular; i++)
                Console.WriteLine($"Pulando linha {i}");
        }

        static int Somar(int z, int x)
        {
            return z + x;
        }
    }
}
