using System;

//Escreva um programa que compare duas strings e determine se são iguais.

namespace CompararStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa CompararStrings--\n");

            Console.Write("Digite uma frase: ");
            string fraseUm = Console.ReadLine();

            Console.Write("Digite outra frase: ");
            string fraseDois = Console.ReadLine();

            if (fraseUm.Equals(fraseDois))
                Console.WriteLine("As duas strings são iguais");
            else
                Console.WriteLine("As duas strings são diferentes");

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
