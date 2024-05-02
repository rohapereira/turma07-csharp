using System;

/*
Faça um programa que: 
- Leia a cotação do dólar 
- Leia um valor em dólares 
- Converta esse valor para Real 
- Mostre o resultado
*/

namespace CotacaoDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa CotacaoDolar--\n");

            Console.Write("Digite a cotação do dolar em R$");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            Console.Write("\nDigite um valor em US$");
            double valorEmDolar = double.Parse(Console.ReadLine());

            double valorEmReal = cotacaoDolar * valorEmDolar;

            Console.Write($"\nUS${valorEmDolar:0.00} convertido para Reais é igual R${valorEmReal:0.00}");

            Console.WriteLine("\n\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
