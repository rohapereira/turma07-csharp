using System;

//Fazer um programa que leia uma frase de até 50 caracteres e imprima a frase sem os espaços em branco. Imprimir também a quantidade de espaços em branco da frase.

namespace _55ImprimirFraseSemEspaços
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ImprimirFraseSemEspaços--");

            Console.Write("\nDigite uma frase de até 50 caracteres: ");
            string frase = Console.ReadLine();

            if (frase.Length > 50)
            {
                Console.WriteLine("\nA frase excede o limite de 50 caracteres.");
                return;
            }

            int espacosEmBranco = 0;
            string fraseSemEspacos = "";

            foreach (char c in frase)
            {
                if (c != ' ')
                    fraseSemEspacos += c;
                else
                    espacosEmBranco++;                
            }

            Console.WriteLine($"\nFrase sem espaços: {fraseSemEspacos}");
            Console.WriteLine($"Quantidade de espaços em branco na frase: {espacosEmBranco}");

            Console.WriteLine("\n--Digite ENTER para sair");
            Console.ReadLine();
        }
    }
}
