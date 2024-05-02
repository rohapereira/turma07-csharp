using System;

/*
Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor maior que zero para cada variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). Exibe o menor valor lido multiplicado pelo maior e o maior valor dividido pelo menor.
*/

namespace _20OperacoesMaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa OperacoesMaiorMenor--");

            Console.WriteLine("\nDigite três valores inteiros maiores que zero:");

            int a, b, c;

            do
            {
                Console.Write("Digite o valor de A (inteiro maior que 0): ");
            } while (!int.TryParse(Console.ReadLine(), out a) || a <= 0);

            do
            {
                Console.Write("Digite o valor de B (inteiro maior que 0): ");
            } while (!int.TryParse(Console.ReadLine(), out b) || b <= 0);

            do
            {
                Console.Write("Digite o valor de C (inteiro maior que 0): ");
            } while (!int.TryParse(Console.ReadLine(), out c) || c <= 0);

            /*
            Esse trecho de código utiliza as funções Math.Min() e Math.Max() da biblioteca System em C# para encontrar o menor e o maior valor entre três variáveis a, b e c.
            Math.Min(a, b) retorna o menor valor entre a e b. Em seguida, Math.Min(Math.Min(a, b), c) compara o resultado anterior (menor entre a e b) com c, retornando assim o menor valor entre a, b e c, que é armazenado na variável menor.
            Similarmente, Math.Max(a, b) retorna o maior valor entre a e b. Math.Max(Math.Max(a, b), c) compara o resultado anterior (maior entre a e b) com c, retornando assim o maior valor entre a, b e c, que é armazenado na variável maior.
            Então, após essas duas linhas de código, você terá nas variáveis menor e maior respectivamente o menor e o maior valor entre a, b e c.
            */
            int menor = Math.Min(Math.Min(a, b), c);
            int maior = Math.Max(Math.Max(a, b), c);

            Console.WriteLine($"\nO menor valor multiplicado pelo maior é: {menor * maior}");

            Console.WriteLine($"O maior valor dividido pelo menor é: {(double)maior / menor:0.00}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
