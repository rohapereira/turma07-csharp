using System;

//Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: "Múltiplo de 10".

namespace _35MultiploDe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MultiploDe10--");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);

                if (i % 10 == 0)
                    Console.WriteLine("Multiplo de 10.");
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
