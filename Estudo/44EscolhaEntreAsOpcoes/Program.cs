using System;

/*
Faça um programa que exiba as opções: 
1 – Conversão de Graus Celsius em Graus Fahrenheit 
2 – Conversão de Graus Fahrenheit em Graus Celsius 
3 – Peso ideal do homem 
4 – Peso ideal da mulher 
O programa só deve encerrar quando o usuário digitar ´S´ para a pergunta “Deseja encerrar o programa?”
Obs.: Nas opções 3 e 4 informar se o usuário está acima ou abaixo do peso ideal.
*/

namespace _44EscolhaEntreAsOpcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa EscolhaEntreAsOpcoes--\n");

            const int CELSIUSPARAFAHRENHEIT = 1, FAHRENHEITPARACELSIUS = 2, PESOIDEALHOMEM = 3, PESOIDEALMULHER = 4;

            int opcao;
            char decisao = 'S';

            do
            {
                Console.WriteLine($"{CELSIUSPARAFAHRENHEIT} - Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine($"{FAHRENHEITPARACELSIUS} - Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine($"{PESOIDEALHOMEM} - Peso ideal do homem");
                Console.WriteLine($"{PESOIDEALMULHER} - Peso ideal da mulher");

                Console.Write("\nInforme uma opção do menu: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case CELSIUSPARAFAHRENHEIT:
                        Console.Write("\nDigite a temperatura em graus Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());

                        double fahrenheit = (9 * celsius + 160) / 5;

                        Console.Write($"\n{celsius}ºC corresponde a {fahrenheit}ºF\n");

                        Console.Write("\nDeseja encerrar o programa? Digite 'S' para sim ou 'N' para não: ");
                        decisao = char.Parse(Console.ReadLine().ToUpper());
                        break;

                    case FAHRENHEITPARACELSIUS:
                        Console.Write("\nDigite a temperatura em graus Fahrenheit: ");
                        double fahrenheit2 = double.Parse(Console.ReadLine());

                        double celsius2 = (fahrenheit2 - 32) * 5 / 9;

                        Console.Write($"\n{fahrenheit2}ºF corresponde a {celsius2}ºC\n");

                        Console.Write("\nDeseja encerrar o programa? Digite 'S' para sim ou 'N' para não: ");
                        decisao = char.Parse(Console.ReadLine().ToUpper());
                        break;

                    case PESOIDEALHOMEM:
                        Console.Write("\nDigite sua altura em metros: ");
                        double alturaHomem = double.Parse(Console.ReadLine());

                        Console.Write("Digite seu peso em quilos: ");
                        double pesoHomem = double.Parse(Console.ReadLine());

                        double pesoIdealHomem = (72.7 * alturaHomem) - 58;

                        Console.Write($"\nO peso ideal para um homem de {alturaHomem} metros de altura é {pesoIdealHomem:0.000}Kg");

                        if (pesoHomem < pesoIdealHomem)
                            Console.Write($"\nSeu peso é de {pesoHomem:0.000}Kg. Você está abaixo do peso ideal.\n");
                        else if (pesoHomem > pesoIdealHomem)
                            Console.Write($"\nSeu peso é de {pesoHomem:0.000}Kg. Você está acima do peso ideal.\n");
                        else
                            Console.Write($"\nSeu peso é de {pesoHomem:0.000}Kg. Você está com o peso ideal.\n");

                        Console.Write("\nDeseja encerrar o programa? Digite 'S' para sim ou 'N' para não: ");
                        decisao = char.Parse(Console.ReadLine().ToUpper());
                        break;

                    case PESOIDEALMULHER:
                        Console.Write("\nDigite sua altura em metros: ");
                        double alturaMulher = double.Parse(Console.ReadLine());

                        Console.Write("Digite seu peso em quilos: ");
                        double pesoMulher = double.Parse(Console.ReadLine());

                        double pesoIdealMulher = (62.1 * alturaMulher) - 44.7;

                        Console.Write($"\nO peso ideal para um homem de {alturaMulher} metros de altura é {pesoIdealMulher:0.000}Kg");

                        if (pesoMulher < pesoIdealMulher)
                            Console.Write($"\nSeu peso é de {pesoMulher:0.000}Kg. Você está abaixo do peso ideal.\n");
                        else if (pesoMulher > pesoIdealMulher)
                            Console.Write($"\nSeu peso é de {pesoMulher:0.000}Kg. Você está acima do peso ideal.\n");
                        else
                            Console.Write($"\nSeu peso é de {pesoMulher:0.000}Kg. Você está com o peso ideal.\n");

                        Console.Write("\nDeseja encerrar o programa? Digite 'S' para sim ou 'N' para não: ");
                        decisao = char.Parse(Console.ReadLine().ToUpper());
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Por favor, informe um número correspondente às opções do menu.");
                        break;
                }

                Console.WriteLine("\nPressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (decisao != 'S');

            Console.WriteLine("\n--Pressione ENTER para fechar o programa--");
            Console.ReadLine();
        }
    }
}
