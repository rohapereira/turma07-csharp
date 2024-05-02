using System;

/*
Faça um programa que leia um número inteiro e mostre uma mensagem indicando se este número é par ou ímpar, e se é positivo ou negativo. O programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?" . 
*/

namespace _39ParImparNegativoPositivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ParImparNegativoPositivo--\n");
            char continuar;

            do
            {
                Console.Write("Digite um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0 && numero >= 0)
                    Console.Write($"\nO número {numero} é par e positivo.");
                else if (numero % 2 == 0 && numero < 0)
                    Console.Write($"\nO número {numero} é par e negativo.");
                else if (numero % 2 != 0 && numero >= 0)
                    Console.Write($"\nO número {numero} é impar e positivo.");
                else if (numero % 2 != 0 && numero < 0)
                    Console.Write($"\nO número {numero} é impar e negativo.");

                Console.Write("\n\nDeseja encerrar o programa? S/N: ");
                continuar = char.ToUpper(Console.ReadKey().KeyChar);

                Console.WriteLine("\n\nPressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (continuar != 'S');

            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
