using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Implemente um programa no qual o usuário deverá informar o nome e a idade de três pessoas. O programa deverá informar o nome da pessoa que possuir a maior idade.

Regras que deverão ser seguidas para a implementação do algoritmo:

-É obrigatório o uso de classe para representar uma pessoa e a mesma deverá possuir como propriedades (características) um nome e uma idade.
-A classe também deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e a idade da pessoa em questão.
-Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e outro que irá receber o nome e a idade de uma pessoa.
*/

namespace MaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MaiorIdade--\n");

            // Criação de uma array de objetos Pessoa
            const int TAMANHOVETOR = 3;
            Pessoa[] pessoas = new Pessoa[TAMANHOVETOR];

            // Loop para entrada de dados
            for (int i = 0; i < TAMANHOVETOR; i++)
            {
                Console.Write($"Digite o nome da pessoa {i + 1}: ");
                string nome = Console.ReadLine();
                Console.Write($"Digite a idade da pessoa {i + 1}: ");
                int idade = int.Parse(Console.ReadLine());

                // Criação de uma nova Pessoa com os dados inseridos
                pessoas[i] = new Pessoa(nome, idade);

                Console.WriteLine();
            }

            // Determinação da pessoa com maior idade
            Pessoa pessoaMaisVelha = pessoas[0];
            for (int i = 1; i < pessoas.Length; i++)
            {
                if (pessoas[i].Idade > pessoaMaisVelha.Idade)
                {
                    pessoaMaisVelha = pessoas[i];
                }
            }

            // Exibição dos dados da pessoa com maior idade
            Console.WriteLine("A pessoa com maior idade é: ");
            pessoaMaisVelha.ExibirDados();

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
