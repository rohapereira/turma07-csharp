using System;

/*
Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um operário. E calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente. O programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?".
*/

namespace _38CalcularSalarioOperario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa CalcularSalarioOperario--\n");

            char continuar;

            do
            {
                Console.Write("Digite o código do operário: ");
                int C = int.Parse(Console.ReadLine());

                Console.Write("Digite o número de horas trabalhadas: ");
                int N = int.Parse(Console.ReadLine());

                double S, E;

                if (N > 50)
                {
                    S = 50 * 10; //Salário até 50 horas
                    E = (N - 50) * 20; //Salário excedente
                }
                else
                {
                    S = N * 10; //Salário normal
                    E = 0; //Não há salário excedente
                }

                double ST = S + E;

                Console.Write($"\n--Operário de código {C}--");
                Console.Write($"\nSalário total: R${ST:0.00}");
                Console.Write($"\nSalário excedente: R${E:0.00}\n");

                Console.Write("\nDeseja encerrar o programa? S/N: ");
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
