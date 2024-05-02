using System;

/*
Escreva um programa que leia um número inteiro (variável CODIGO). Verificar se o código é igual a 1, igual a 2 ou 
igual a 3. Caso não seja, apresentar a mensagem “Código inválido”. Ao ser verificado o código e constatado que é 
um valor válido, o programa deve verificar cada código em separado para determinar seu valor por extenso, ou 
seja, apresentar a mensagem “um”, ”dois” ou “três”. (Utilizar o comando Switch).
*/

namespace _18Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Switch--");

            Console.Write("\nDigite um código: ");
            int codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("\num");
                    break;
                case 2:
                    Console.WriteLine("\ndois");
                    break;
                case 3:
                    Console.WriteLine("\ntrês");
                    break;
                default:
                    Console.WriteLine("\nCódigo inválido.");
                    break;
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
