using System;

/*
Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de 
temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus 
Fahrenheit e a variável C representa é a temperatura em graus Celsius. 
*/

namespace CelsiusParaFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa CelsiusParaFahrenheit--");

            Console.Write("\nDigite a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine($"\n{celsius}ºC corresponde a {fahrenheit}ºF");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
