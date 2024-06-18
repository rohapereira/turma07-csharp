using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Crie um programa que exiba para o usuário qual é a área de um retângulo. Para implementar esse programa você deverá seguir as seguintes regras:

-O usuário deverá informar para o programa o valor da base e altura do retângulo/quadrado.
-É obrigatório criar/utilizar uma classe para representar o retângulo/quadrado.
-A base e a altura informada pelo usuário deveram ser representadas na classe como propriedades.
-O objeto deverá possuir uma propriedade para exibir o valor da área do retângulo/quadrado
-O objeto deverá possuir um método que exiba os dados de todas as suas propriedades.
*/

namespace AreaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa AreaRetangulo--");

            Retangulo retangulo = new Retangulo();

            Console.Write("\nInforme a altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.Write("Informe a base: ");
            retangulo.Base = double.Parse(Console.ReadLine());

            Console.WriteLine();

            retangulo.ExibeDados();

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
