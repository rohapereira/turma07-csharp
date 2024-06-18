using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3) Crie uma classe Retangulo, com altura e largura passadas como argumento no método construtor. Também deve ter um método Mostrar que imprime a altura e a largura do retângulo. Crie um array contendo 10 retângulos, solicite ao usuário suas dimensões e depois as mostre na tela.

namespace Lista1Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Lista1Exercicio03--\n");

            const int TAMANHO = 10;
            List<Retangulo> vetor = new List<Retangulo>();

            // Alimentando o vetor
            for (int i = 0; i < TAMANHO; i++)
            {
                Console.WriteLine($"Preenchimento do retângulo {i+1}");

                vetor.Add(LeRetangulo());

                Console.WriteLine();
            }

            // Mostrando todos os retangulos do vetor
            for (int i = 0; i < vetor.Count; i++)
            {
                Console.Write($"Retângulo {i+1}: ");

                vetor[i].Mostrar();
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }

        public static Retangulo LeRetangulo()
        {
            Retangulo r = new Retangulo();

            Console.Write("Digite a altura: ");
            r.altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a largura: ");
            r.largura = double.Parse(Console.ReadLine());

            return r;
        }
    }
}
