using System;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;

namespace PesoIdeal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para calcular o peso ideal de uma pessoa. Lembrando que a pessoa pode optar por não dizer seu sexo. O programa tem que ler o sexo da pessoa(M(masculino) F(feminino) 0(prefere nao dizer)). O Calculo de IMC é o calculo usado para chegar no peso ideal de um ser humano.e ele é calculado: Peso / Altura². A partir do resultado mostrar em qual das categorias abaixo o usuário está encaixado. O Peso ideal de uma pessoa é dado pelas tabelas abaixo:

            //Qando a pessoa não fornece o sexo.
            //IMC             |Categoria
            //abaixo de 16,00 |Baixo peso Grau III
            //16,00 a 16,99   |Baixo peso Grau II
            //17,00 a 18.49   |Baixo peso Grau I
            //18,50 a 24,99   |Peso ideal
            //25,00 a 29,99   |Sobrepeso
            //30,00 a 34,99   |Obesidade Grau I
            //35,00 a 39,99   |Obesidade Grau II
            //40,0 e acima    |Obesidade Grau III
            //---------------------------------------
            //Caso sexo for Masculino
            //IMC              |Categoria
            //Abaixo de 20, 7  |Abaixo do peso
            //20,7 a 26,4      |Peso ideal
            //26,5 a 27,8      |Pouco acima do peso
            //27,9 a 31,1      |Acima do peso
            //31,2 e acima     |Obesidade
            //---------------------------------------
            //Caso sexo for Feminino
            //IMC     |Categoria
            //Abaixo de 19, 1  |Abaixo do peso
            //19,1 a 25,8 |Peso ideal
            //25,9 a 27,3 |Pouco acima do peso
            //27,4 a 32,3 |Acima do peso
            //32,4 e acima    |Obesidade
            //---------------------------------------

            double imc;

            Console.WriteLine("--Bem vindo ao programa DecisaoSimples--");
            Console.WriteLine();

            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.Write("Digite seu genero (M para Masculino, F para feminino ou 0 caso não queira informar): ");
            string genero = Console.ReadLine().ToUpper();

            Console.WriteLine($"Genero digitado: {genero}, IMC calculado: {imc:0.00}");

            if (genero == "M" || genero == "F")
            {
                if (genero == "M")
                {
                    if (imc < 20.7)
                        Console.WriteLine("Abaixo do peso");
                    if (imc >= 20.7 && imc < 26.4)
                        Console.WriteLine("Peso ideal");
                    if (imc >= 26.5 && imc < 27.8)
                        Console.WriteLine("Pouco acima do peso");
                    if (imc >= 27.9 && imc < 31.1)
                        Console.WriteLine("Acima do peso");
                    if (imc >= 31.1)
                        Console.WriteLine("Obesidade");
                }
                else
                {
                    if (imc < 19.1)
                        Console.WriteLine("Abaixo do peso");
                    if (imc >= 19.1 && imc < 25.8)
                        Console.WriteLine("Peso ideal");
                    if (imc >= 25.9 && imc < 27.3)
                        Console.WriteLine("Pouco acima do peso");
                    if (imc >= 27.4 && imc < 32.3)
                        Console.WriteLine("Acima do peso");
                    if (imc >= 32.3)
                        Console.WriteLine("Obesidade");
                }
            }
            else
            {
                if (imc < 16)
                    Console.WriteLine("Baixo peso Grau III");
                if (imc >= 16 && imc < 16.99)
                    Console.WriteLine("Baixo peso Grau II");
                if (imc >= 17 && imc < 18.49)
                    Console.WriteLine("Baixo peso Grau I");
                if (imc >= 18.50 && imc < 24.99)
                    Console.WriteLine("Peso ideal");
                if (imc >= 25 && imc < 29.99)
                    Console.WriteLine("Sobrepeso");
                if (imc >= 30 && imc < 34.99)
                    Console.WriteLine("Obesidade Grau I");
                if (imc >= 35 && imc < 39.99)
                    Console.WriteLine("Obesidade Grau II");
                if (imc >= 40)
                    Console.WriteLine("Obesidade Grau III");
            }

            Console.WriteLine();
            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
