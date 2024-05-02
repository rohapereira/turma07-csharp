using System;

/*
Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja 
realizar: 
1 – Verificar se um dos números lidos é ou não múltiplo do outro 
2 – Verificar se os dois números lidos são pares 
3 – Verificar se a média dos dois números é maior ou igual a 7. 
4 – Sair 
*/

namespace _24Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Calculos--");

            const int MULTIPLO = 1, PARES = 2, MEDIA = 3, SAIR =4;

            int opcao;
            do
            {
                Console.Write("\nDigite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine($"{MULTIPLO} - Verificar se os números são multiplos");
                Console.WriteLine($"{PARES} - Verificar se os números são pares");
                Console.WriteLine($"{MEDIA} - Verificar se a média dos número é igual ou maior que 7");
                Console.WriteLine($"{SAIR} - Sair");

                Console.Write("\nInforme uma opção do menu: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Por favor, informe um número correspondente às opções do menu.");
                    continue;
                }

                switch (opcao)
                {
                    case MULTIPLO:
                        if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
                            Console.WriteLine("Um dos números é múltiplo do outro.");
                        else
                            Console.WriteLine("Nenhum dos números é múltiplo do outro.");
                        break;
                    case PARES:
                        if (numero1 % 2 == 0 && numero2 % 2 == 0)
                            Console.WriteLine("Ambos os números são pares.");
                        else
                            Console.WriteLine("Pelo menos um dos números não é par.");
                        break;
                    case MEDIA:
                        double media = (numero1 + numero2) / 2;
                        if (media >= 7)
                            Console.WriteLine("A média dos números é maior ou igual a 7");
                        else
                            Console.WriteLine("A média dos números é menor que 7");
                        break;
                    case SAIR:
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, informe um número correspondente às opções do menu.");
                        break;
                }

                Console.WriteLine("\nPressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (opcao != SAIR);

            Console.WriteLine("Pressione ENTER para fechar o programa");
            Console.ReadLine();
        }
    }
}
