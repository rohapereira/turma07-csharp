using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Tabuada--\n");

            Console.Write("Digite um número inteiro: ");
            int numeroDigitado = int.Parse(Console.ReadLine());

            Console.WriteLine("A tabuada do número digitado é: ");

            #region "Tabuada Manual"
            //Console.WriteLine($"{numeroDigitado} x 0 = {numeroDigitado * 0}");
            //Console.WriteLine($"{numeroDigitado} x 1 = {numeroDigitado * 1}");
            //Console.WriteLine($"{numeroDigitado} x 2 = {numeroDigitado * 2}");
            //Console.WriteLine($"{numeroDigitado} x 3 = {numeroDigitado * 3}");
            //Console.WriteLine($"{numeroDigitado} x 4 = {numeroDigitado * 4}");
            //Console.WriteLine($"{numeroDigitado} x 5 = {numeroDigitado * 5}");
            //Console.WriteLine($"{numeroDigitado} x 6 = {numeroDigitado * 6}");
            //Console.WriteLine($"{numeroDigitado} x 7 = {numeroDigitado * 7}");
            //Console.WriteLine($"{numeroDigitado} x 8 = {numeroDigitado * 8}");
            //Console.WriteLine($"{numeroDigitado} x 9 = {numeroDigitado * 9}");
            //Console.WriteLine($"{numeroDigitado} x 10 = {numeroDigitado * 10}");
            #endregion

            #region "For"
            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine($"{numeroDigitado} x {i} = {numeroDigitado * i}");
            //}
            #endregion

            #region "While"
            //int i = 0;
            //while (i < 11)
            //{
            //    Console.WriteLine($"{numeroDigitado} x {i} = {numeroDigitado * i}");
            //    i++;
            //}
            #endregion

            #region "Do-while"
            int i = 0;
            do
            {
                Console.WriteLine($"{numeroDigitado} x {i} = {numeroDigitado * i}");
                i++;
            } while (i <= 10);
            #endregion

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
