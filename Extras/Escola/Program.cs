using System;

//Desenvolva um programa que determine se uma pessoa está aprovada ou reprovada em uma disciplina com base em sua nota (considerando uma nota mínima para aprovação).

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double MEDIAAPROVAÇÃO = 7;

            Console.WriteLine("--Bem vindo ao programa Escola--\n");

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (media < MEDIAAPROVAÇÃO)
                Console.WriteLine("Reprovado!");
            else
                Console.WriteLine("Aprovado!");

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
