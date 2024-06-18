using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Crie uma classe Retangulo, com altura e largura passadas como argumento no método construtor. Também deve ter um método Mostrar que imprime a altura e a largura do retângulo. Crie um array contendo 10 retângulos, solicite ao usuário suas dimensões e depois as mostre na tela.

namespace Lista1Exercicio03
{
    public class Retangulo
    {
        // Atributos
        public double altura, largura;

        // Construtor vazio
        public Retangulo()
        {
        }

        // Construtor com parâmetros
        public Retangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        // Método Mostrar
        public void Mostrar()
        {
            Console.WriteLine($"Altura = {altura:0.00}, Largura = {largura:0.00}");
        }
    }
}
