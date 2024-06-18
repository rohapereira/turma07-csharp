using System;

//Escreva um programa que verifique se um número é par ou ímpar através de um método chamado VERIFICA. O método deverá receber um número inteiro (n) e deverá retornar a mensagem “PAR” ou “ÍMPAR”.

namespace _63MetodoParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MetodoParImpar--");

            Console.Write("\nDigite um número qualquer: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nO número digitado é {Verifica(numero)}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
        static string Verifica(int numero)
        {
            if (numero % 2 == 0)
                return "PAR";
            else
                return "ÍMPAR";
        }
    }
}
