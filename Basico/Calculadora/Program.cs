using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declara duas variáveis
            int numero1 = 0;
            int numero2 = 0;

            //mostra na tela uma frase e aguarda o usuário digitar um número
            Console.Write("Digite um número inteiro: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite mais um número inteiro: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("A soma dos números é: " + (numero1 + numero2));
            Console.WriteLine("A subtração dos números é: " + (numero1 - numero2));
            Console.WriteLine("A divisão dos números é: " + (numero1 / numero2));
            Console.WriteLine("A multiplicação dos números é: " + (numero1 * numero2));
            Console.WriteLine("O resto da divisão dos números é: " + (numero1 % numero2));
            Console.WriteLine();

            Console.WriteLine("Digite enter para encerrar o código!");
            Console.ReadLine();
        }
    }
}
