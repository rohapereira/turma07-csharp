using System;

/*
Escreva um programa que calcule e retorne o valor da hipotenusa através do método HIPOTENUSA. O método recebe o valor da base e da altura de um triângulo.
Fórmulas: hipotenusa² = base² + altura² 
            base x altura 
área = ---------------------- 
                 2 
*/

namespace _62MetodoHipotenusa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MetodoHipotenusa--");

            // Solicita ao usuário os valores da base e da altura
            Console.Write("\nDigite o valor da base do triângulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura do triângulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            // Calcula a hipotenusa
            double hipotenusa = Hipotenusa(baseTriangulo, alturaTriangulo);

            Console.WriteLine($"\nA hipotenusa do triângulo é: {hipotenusa:F2}");

            // Calcula a área
            double area = Area(baseTriangulo, alturaTriangulo);

            Console.WriteLine($"\nA área do triângulo é: {area:F2}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }

        // Método que calcula a hipotenusa usando a fórmula hipotenusa² = base² + altura²
        static double Hipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            return Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
        }

        // Método que calcula a área usando a fórmula área = (base x altura) / 2
        static double Area(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }
}
