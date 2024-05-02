using System;

namespace KelvinCelsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para ler uma temperatura em graus Kelvin e apresentar a temperatura convertida em graus Celsius. A fórmula da conversão é: C = K - 273,15, sendo K a temperatura em kelvin e C a temperatura em Celsius

            const double valor = 273.15;

            Console.WriteLine("--Bem vindo ao programa Cubo--");
            Console.WriteLine();

            Console.Write("Digite a temperatura em graus Kelvin: ");
            double kelvin = double.Parse(Console.ReadLine());

            Console.WriteLine($"{kelvin:0.00} K é igual a {kelvin - valor:0.00} °C");

            Console.WriteLine();
            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();

        }
    }
}
