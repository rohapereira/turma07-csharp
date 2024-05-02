using System;

/*
Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os 
valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis 
A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B 
com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo,
devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as 
multiplicações.
*/

namespace PropriedadeDistributiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa PropriedadeDistributiva--");

            Console.Write("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int numero3 = int.Parse(Console.ReadLine());

            Console.Write("Digite o quarto número: ");
            int numero4 = int.Parse(Console.ReadLine());

            int soma1 = numero1 + numero2;
            int soma2 = numero1 + numero3;
            int soma3 = numero1 + numero4;
            int soma4 = numero2 + numero3;
            int soma5 = numero2 + numero4;
            int soma6 = numero3 + numero4;

            int multiplicacao1 = numero1 * numero2;
            int multiplicacao2 = numero1 * numero3;
            int multiplicacao3 = numero1 * numero4;
            int multiplicacao4 = numero2 * numero3;
            int multiplicacao5 = numero2 * numero4;
            int multiplicacao6 = numero3 * numero4;

            Console.WriteLine("\nResultados: ");
            Console.Write($"\n{numero1} + {numero2} = {soma1}");
            Console.Write($"\n{numero1} + {numero3} = {soma2}");
            Console.Write($"\n{numero2} + {numero3} = {soma4}");
            Console.Write($"\n{numero2} + {numero4} = {soma5}");
            Console.Write($"\n{numero3} + {numero4} = {soma6}");
            Console.Write($"\n{numero1} * {numero2} = {multiplicacao1}");
            Console.Write($"\n{numero1} * {numero3} = {multiplicacao2}");
            Console.Write($"\n{numero1} * {numero4} = {multiplicacao3}");
            Console.Write($"\n{numero2} * {numero3} = {multiplicacao4}");
            Console.Write($"\n{numero2} * {numero4} = {multiplicacao5}");
            Console.WriteLine($"\n{numero3} * {numero4} = {multiplicacao6}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
