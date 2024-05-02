using System;

/*
A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03 grupos de indústrias que são altamente poluentes do meio ambiente. O índice de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe para 0,3 as indústrias do 1º grupo são intimadas a suspenderem suas atividades, se o índice crescer para 0,4 as industrias do 1º e 2º grupo são intimadas a suspenderem suas atividades, se o índice atingir 0,5 todos os grupos devem ser notificados a paralisarem suas atividades. Faça um programa que leia o índice de poluição medido e emita a notificação adequada aos diferentes grupos de empresas. O algoritmo só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?".
*/

namespace _40SecretariaMeioAmbiente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa SecretariaMeioAmbiente--\n");

            const double INDICEPOLUICAOACEITAVELMIN = 0.05, INDICEPOLUICAOACEITAVELMAX = 0.25, GRUPO1 = 0.3, GRUPO2 = 0.4, GRUPO3 = 0.5;
            char continuar;

            do
            {
                Console.Write("Digite o índice de poluição medida: ");
                double indicePoluicaoMedida = double.Parse(Console.ReadLine());

                if (indicePoluicaoMedida <= INDICEPOLUICAOACEITAVELMAX)
                {
                    Console.Write($"\nO índice de poluição medido {indicePoluicaoMedida} está dentro do aceitável de {INDICEPOLUICAOACEITAVELMIN} até {INDICEPOLUICAOACEITAVELMAX}.");
                }
                else if (indicePoluicaoMedida >= GRUPO1 && indicePoluicaoMedida < GRUPO2)
                {
                    Console.Write($"\nÍndice de poluição em {indicePoluicaoMedida}. Empresas do Grupo 1 devem suspender suas atividades!");
                }
                else if (indicePoluicaoMedida >= GRUPO2 && indicePoluicaoMedida < GRUPO3)
                {
                    Console.Write($"\nÍndice de poluição em {indicePoluicaoMedida}. Empresas do Grupo 1 e 2 devem suspender suas atividades!");
                }
                else 
                {
                    Console.Write($"\nÍndice de poluição em {indicePoluicaoMedida}. Empresas do Grupo 1, 2 e 3 devem suspender suas atividades!");
                }

                Console.Write("\n\nDeseja encerrar o programa? S/N: ");
                continuar = char.ToUpper(Console.ReadKey().KeyChar);

                Console.WriteLine("\n\nPressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (continuar != 'S');

            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
