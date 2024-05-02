using System;

//Desenvolva um programa que verifique se uma pessoa pode votar com base em sua idade (considerando a idade mínima permitida para votar).

namespace IdadeMinimaVotar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa IdadeMinimaVotar--\n");

            Console.Write("Digite o ano do seu nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = DateTime.Now.Year - anoNascimento;

            if (idade >= 16)
            {
                Console.WriteLine($"Você tem {idade} anos, portanto você tem idade suficiente para votar.");
            }
            else
            {
                Console.WriteLine($"Você tem {idade} anos, portanto você não tem idade suficiente para votar.");
            }

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}