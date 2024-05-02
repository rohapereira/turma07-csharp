using System;

//Projeto Elevador
//Faça um programa que mostre se um elevador pode entrar em funcionamento ou não. Primeiro o programa deve solicitar o peso máximo, em kg, suportado pelo elevador e o numero de pessoas que desejam utilizá-lo. Depois solicitar o peso de cada pessoa e, no final, exibir se o elevador poderá entrar em funcionamento ou não. Caso a soma das pessoas for maior que o peso máximo suportado pelo elevador, ele não poderá entrar em funcionamento.

namespace Elevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Elevador--\n");

            #region "Minha solução"
            //Console.WriteLine("Informe o peso máximo suportado pelo elevador (em kg):");
            //double pesoMaximo = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o número de pessoas que desejam utilizar o elevador:");
            //int numeroDePessoas = int.Parse(Console.ReadLine());

            //double pesoTotal = 0;

            //for (int i = 1; i <= numeroDePessoas; i++)
            //{
            //    Console.WriteLine($"Informe o peso da pessoa {i} (em kg):");
            //    int pesoPessoa = int.Parse(Console.ReadLine());
            //    pesoTotal += pesoPessoa;
            //}

            //if (pesoTotal <= pesoMaximo)
            //    Console.WriteLine("O elevador pode entrar em funcionamento.");
            //else
            //    Console.WriteLine("O elevador não pode entrar em funcionamento devido ao excesso de peso.");
            #endregion

            #region "Solução do Professor"
            double pesoTotalDasPessoas = 0;

            Console.WriteLine("Informe o peso máximo suportado pelo elevador (em kg):");
            double pesoTotalSuportado = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de pessoas que desejam utilizar o elevador:");
            double numeroDePessoas = double.Parse(Console.ReadLine());

            for (int i = 0; i < numeroDePessoas;  i++)
            {
                Console.WriteLine($"Digite o peso da pessoa {i+1} em Kg por gentileza: ");
                int pedoDeCadaPessoa = int.Parse(Console.ReadLine());
                pesoTotalDasPessoas += pedoDeCadaPessoa;
            }

            if (pesoTotalDasPessoas > pesoTotalSuportado)
                Console.WriteLine("O elevador não poderá entrar em funcionamento");
            else
                Console.WriteLine("O elevador poderá entrar em funcionamento");
            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
