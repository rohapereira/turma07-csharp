using System;

//Projeto: Tinder
//Zequinha esta procurando uma namorada no tinder. Para isso, ele preencheu seu cadastro com algumas preferencias. Que ele quer uma namorada do sexo feminino, altura entre 1,60 e 1,75 , peso entre 50 e 80 quilos, idade entre 22 e 30 e cabelo loiro ou ruivo. Assim faça um programa que receba os seguintes dados de um perfil: nome, sexo, altura, peso, idade, cor de cabelo e determine se este perfil é compatível com o perfil cadastrado pelo Zequinha. Então, após a execução, o programa deve imprimir o nome do perfil e se ele é compatível ou não com o perfil do Zequinha, como por exemplo: "Joana é compatível" ou "Joana não é compatível".

namespace Tinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const char CORCABELOLOIRO = 'R', CORCABELORUIVO = 'L';
            const double PESOMINIMO = 50, PESOMAXIMO = 80;
            const double ALTURAMINIMA = 1.60, ALTURAMAXIMA = 1.75;
            const int IDADEMINIMA = 22, IDADEMAXIMA = 30;
            const char SEXOFEMININO = 'F';

            Console.WriteLine("--Bem vindo ao programa Tinder--\n");

            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sexo (M)Masculino ou (F)Feminino");
            char sexo = char.Parse(Console.ReadLine().ToUpper());

            if (sexo == SEXOFEMININO)
            {
                Console.WriteLine("Digite a sua altura em metros");
                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu peso em quilos");
                double peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite sua idade");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a cor do seu cabelo: L-(Loiro) ou R-(Ruivo)");
                char cabelo = char.Parse(Console.ReadLine().ToUpper());

                #region "Estrutura de Decisão Composta"
                //if (altura >= ALTURAMINIMA && altura <= ALTURAMAXIMA && peso >= PESOMINIMO &&  peso <= PESOMAXIMO && idade >= IDADEMINIMA && idade <= IDADEMAXIMA && (cabelo == CORCABELOLOIRO || cabelo == CORCABELORUIVO))
                //    Console.WriteLine($"{nome} é compatível");
                //else
                //    Console.WriteLine($"{nome} não é compatível");
                #endregion

                #region "Estrutura de decisão Ternário"
                string respostaParaUsuario = (altura >= ALTURAMINIMA && altura <= ALTURAMAXIMA && peso >= PESOMINIMO &&  peso <= PESOMAXIMO && idade >= IDADEMINIMA && idade <= IDADEMAXIMA && (cabelo == CORCABELOLOIRO || cabelo == CORCABELORUIVO)) ? $"{nome} é compatível" : $"{nome} não é compatível";

                Console.WriteLine(respostaParaUsuario);
                #endregion
            }
            else
                Console.WriteLine($"{nome} não é compatível");

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
