using System;

namespace AntesDepois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa AntesDepois--");

            Console.Write("Digite um número: ");
            int numeroDigitado = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Seu antecessor é: {numeroDigitado - 1}");
            //Console.WriteLine("Seu antecessor é: {0} e o sucessor é {1}", numeroDigitado - 1, numeroDigitado + 1);
            Console.WriteLine($"Seu antecessor é {numeroDigitado - 1} e o sucessor é {numeroDigitado + 1}");

            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
