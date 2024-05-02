using System;

//Projeto: Prefeitura
//A prefeitura de uma cidade fez uma pesquisa com seus habitantes coletando dados sobre salário e número de filhos. Faça um programa para a prefeitura saber: 
//a.A média do sálario da população;
//b.A média do número de filhos;
//c.O maior salário;
//d.O % de pessoas com salário até R$ 150,00.
//O programa vai ficar em loop até o usuário digitar que não há mais habitantes para fazer a pesquisa.

namespace Prefeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "Minha solução"
            //Console.WriteLine("--Bem vindo ao programa Prefeitura--\n");

            //const double SALARIOMINIMO = 150;
            //double somaSalarios = 0;
            //int somaFilhos = 0;
            //double maiorSalario = 0;
            //int contadorSalario150 = 0;
            //int contadorHabitantes = 0;

            //while (true)
            //{
            //    Console.WriteLine("Digite o salário do habitante (ou digite '0' se não houver mais habitantes):");
            //    double salario = double.Parse(Console.ReadLine());

            //    if (salario == 0)
            //        break;

            //    Console.WriteLine("Digite o número de filhos do habitante:");
            //    int numFilhos = int.Parse(Console.ReadLine());

            //    somaSalarios += salario;
            //    somaFilhos += numFilhos;
            //    contadorHabitantes++;

            //    if (salario > maiorSalario)
            //        maiorSalario = salario;

            //    if (salario <= SALARIOMINIMO)
            //        contadorSalario150++;
            //}

            //double mediaSalario = somaSalarios / contadorHabitantes;
            //double mediaFilhos = (double)somaFilhos / contadorHabitantes;
            //double percentualSalario150 = (double)contadorSalario150 / contadorHabitantes * 100;

            //Console.WriteLine("\nResultados da pesquisa:");
            //Console.WriteLine($"a. Média do salário da população: R${mediaSalario:0.00}");
            //Console.WriteLine($"b. Média do número de filhos: {mediaFilhos:0.00}");
            //Console.WriteLine($"c. Maior salário: R${maiorSalario:0.00}");
            //Console.WriteLine($"d. % de pessoas com salário até R$ 150,00: {percentualSalario150:0.00}%");

            //Console.Write("\n--Digite ENTER para sair--\n");
            //Console.ReadLine();
            #endregion

            #region "Solução do Professor"
            const double SALARIOMINIMO = 150;
            double somaSalario = 0, maiorSalario = 0;
            int quantidadeDePessoasComSalarioAte150 = 0;

            int somaNumeroFilhos = 0;

            int quantidadeDePessoas = 0;
            int contadorNaoQuiseramResponder = 0;

            Console.WriteLine("--Bem vindo ao programa Prefeitura--");

            int contador = 1;

            while (contador != 0)
            {
                Console.WriteLine("Deseja responder o questionário? (0-não 1-sim 2-finalizar aplicação)");
                int desejaResponder = int.Parse(Console.ReadLine());

                if (desejaResponder != 0 && desejaResponder != 1)
                    contador = 0;
                else if (desejaResponder == 0)
                {
                    contadorNaoQuiseramResponder++;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Qual o seu salario?");
                    double salario = double.Parse(Console.ReadLine());
                    somaSalario += salario;
                    if (salario > maiorSalario)
                        maiorSalario = salario;

                    Console.WriteLine("Quantos filhos você tem?");
                    int quantidadeFilhos = int.Parse(Console.ReadLine());
                    somaNumeroFilhos += quantidadeFilhos;

                    if (salario <= SALARIOMINIMO)
                        quantidadeDePessoasComSalarioAte150++;

                    quantidadeDePessoas++;
                }

                if (quantidadeDePessoas == 0)
                    quantidadeDePessoas = 1;
            }

            Console.WriteLine($"A média do salario da população é: {somaSalario/ quantidadeDePessoas:0.00}");
            Console.WriteLine($"A média do numero de filhos é: {(double)somaNumeroFilhos/quantidadeDePessoas:0.00}");
            Console.WriteLine($"O maior salario é: {maiorSalario:0.00}");
            Console.WriteLine($"O % de pessoas com salario até R$ 150,00 é {(double)quantidadeDePessoasComSalarioAte150 / quantidadeDePessoas * 100:0.00}%");
            Console.WriteLine($"Quantidade de pessoas que não quiseram responder o senso: {contadorNaoQuiseramResponder}");

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
            #endregion
        }
    }
}
