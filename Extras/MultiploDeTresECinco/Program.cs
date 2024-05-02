using System;

//Crie um programa que verifique se um número digitado é múltiplo de 3 e de 5 ao mesmo tempo.

namespace MultiploDeTresECinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MultiploDeTresECinco--\n");

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 3 == 0 && numero % 5 == 0)
                Console.WriteLine($"O número {numero} é multiplo de 3 e 5");
            else
                Console.WriteLine($"O número {numero} não é multiplo de 3 e 5");

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
