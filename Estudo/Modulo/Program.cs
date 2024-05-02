using System;

/*
Escreva um programa que leia um número inteiro e exiba o seu módulo. 
O módulo de um número x é: 
x se x é maior ou igual a zero 
x * (-1) se x é menor que zero
*/

namespace Modulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Modulo--");

            Console.Write("\nDigite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            int modulo;

            #region "Solução com if"
            //if (numero >= 0) {
            //    modulo = numero;
            //}
            //else
            //{
            //    modulo = numero * (-1);
            //}
            #endregion

            #region "Solução com ternário"
            modulo = numero >= 0 ? numero : numero * (-1);
            #endregion

            Console.WriteLine($"\nO módulo de {numero} é {modulo}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
