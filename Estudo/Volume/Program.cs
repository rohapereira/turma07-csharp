using System;

/*
Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula: 
V = 3.14159 * R * R * A 
Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.
*/

namespace Volume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Volume--");

            const double PI = 3.14159;

            Console.Write("\nDigite o raio em cm: ");
            double raio = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura em cm: ");
            double altura = double.Parse(Console.ReadLine());

            double volume = PI * raio * raio * altura;

            Console.WriteLine($"\nO volume é: {volume:0.00} cm³");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
