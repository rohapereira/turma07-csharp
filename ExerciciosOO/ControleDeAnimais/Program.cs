using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Crie um algoritmo/programa no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e peixes foram informados.

Regras que deverão ser seguidas para a implementação do algoritmo:

-Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
-Caso seja informado um tipo diferente o programa deverá definir o tipo do animal como Peixe.
-É obrigatório criar uma classe para representar o Animal.
-A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
-A classe deverá possuir métodos de acesso para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).
*/

namespace ControleDeAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ControleDeAnimais--");

            #region "Solução 1"
            //Animal a1 = new Animal();
            //Animal a2 = new Animal();
            //Animal a3 = new Animal();
            //Animal a4 = new Animal();
            //Animal a5 = new Animal();
            //int contadorCachorro = 0, contadorGato = 0, contadorPeixe = 0;

            ////Primeiro animal
            //Console.Write("\nInforme o nome do 1º animal: ");
            //a1.Nome = Console.ReadLine();
            //Console.Write("Informe o tipo do 1º animal (Cachorro, Gato ou Peixe): ");
            //a1.Tipo = Console.ReadLine();

            //if (a1.Tipo == "Cachorro")
            //    contadorCachorro++;
            //if (a1.Tipo == "Gato")
            //    contadorGato++;
            //if (a1.Tipo == "Peixe")
            //    contadorPeixe++;

            //Console.WriteLine();

            ////Segundo animal
            //Console.Write("Informe o nome do 2º animal: ");
            //a2.Nome = Console.ReadLine();
            //Console.Write("Informe o tipo do 2º animal (Cachorro, Gato ou Peixe): ");
            //a2.Tipo = Console.ReadLine();

            //if (a2.Tipo == "Cachorro")
            //    contadorCachorro++;
            //if (a2.Tipo == "Gato")
            //    contadorGato++;
            //if (a2.Tipo == "Peixe")
            //    contadorPeixe++;

            //Console.WriteLine();

            ////Terceiro animal
            //Console.Write("Informe o nome do 3º animal: ");
            //a3.Nome = Console.ReadLine();
            //Console.Write("Informe o tipo do 3º animal (Cachorro, Gato ou Peixe): ");
            //a3.Tipo = Console.ReadLine();

            //if (a3.Tipo == "Cachorro")
            //    contadorCachorro++;
            //if (a3.Tipo == "Gato")
            //    contadorGato++;
            //if (a3.Tipo == "Peixe")
            //    contadorPeixe++;

            //Console.WriteLine();

            ////Quarto animal
            //Console.Write("Informe o nome do 4º animal: ");
            //a4.Nome = Console.ReadLine();
            //Console.Write("Informe o tipo do 4º animal (Cachorro, Gato ou Peixe): ");
            //a4.Tipo = Console.ReadLine();

            //if (a4.Tipo == "Cachorro")
            //    contadorCachorro++;
            //if (a4.Tipo == "Gato")
            //    contadorGato++;
            //if (a4.Tipo == "Peixe")
            //    contadorPeixe++;

            //Console.WriteLine();

            ////Quinto animal
            //Console.Write("Informe o nome do 5º animal: ");
            //a5.Nome = Console.ReadLine();
            //Console.Write("Informe o tipo do 5º animal (Cachorro, Gato ou Peixe): ");
            //a5.Tipo = Console.ReadLine();

            //if (a5.Tipo == "Cachorro")
            //    contadorCachorro++;
            //if (a5.Tipo == "Gato")
            //    contadorGato++;
            //if (a5.Tipo == "Peixe")
            //    contadorPeixe++;

            ////Resultado
            //Console.WriteLine("\nTotal de animais: ");
            //Console.WriteLine($"Cachorros: {contadorCachorro}\nGatos: {contadorGato} \nPeixes: {contadorPeixe}");
            #endregion

            #region "Solução 2"
            // Criação de uma array de objetos Animal
            const int TAMANHOVETOR = 5;
            Animal[] animais = new Animal[TAMANHOVETOR];

            // Leitura dos dados dos animais
            for (int i = 0; i < TAMANHOVETOR; i++)
            {
                Console.WriteLine($"\nInforme os dados do {i + 1}º animal:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Tipo (Cachorro, Gato, Peixe): ");
                string tipo = Console.ReadLine();

                animais[i] = new Animal(nome, tipo);
            }

            // Contadores
            int cachorros = 0;
            int gatos = 0;
            int peixes = 0;

            // Contagem dos tipos de animais
            foreach (Animal animal in animais)
            {
                switch (animal.Tipo)
                {
                    case "Cachorro":
                        cachorros++;
                        break;
                    case "Gato":
                        gatos++;
                        break;
                    case "Peixe":
                        peixes++;
                        break;
                }
            }

            // Exibição dos resultados
            Console.WriteLine($"\nTotal de Cachorros: {cachorros}");
            Console.WriteLine($"Total de Gatos: {gatos}");
            Console.WriteLine($"Total de Peixes: {peixes}");
            #endregion

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
