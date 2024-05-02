using System;

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Loteria--");
            Console.WriteLine();

            Console.Write("Digite o valor do premio da Loteria: R$");
            double premio = double.Parse(Console.ReadLine());

            Console.Write("Valor que o primeiro amigo apostou: R$");
            double primeiroAmigo = double.Parse(Console.ReadLine());

            Console.Write("Valor que o segundo amigo apostou: R$");
            double segundoAmigo = double.Parse(Console.ReadLine());

            Console.Write("Valor que o terceiro amigo apostou: R$");
            double terceiroAmigo = double.Parse(Console.ReadLine());

            double totalApostado = primeiroAmigo + segundoAmigo + terceiroAmigo;

            Console.WriteLine();
            Console.WriteLine($"O valor que o primeiro amigo ganhou foi R${(primeiroAmigo / totalApostado) * premio:0.00} e o valor apostado foi R${primeiroAmigo:0,00}");
            Console.WriteLine($"O valor que o segundo amigo ganhou foi R${(segundoAmigo / totalApostado) * premio:0.00} e o valor apostado foi R${segundoAmigo:0,00}");
            Console.WriteLine($"O valor que o terceiro amigo ganhou foi R${(terceiroAmigo / totalApostado) * premio:0.00} e o valor apostado foi R${terceiroAmigo:0,00}");
            Console.WriteLine();

            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
