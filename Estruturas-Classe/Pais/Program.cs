using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Projeto: País
Um país tem como atributos o seu nome, o nome da sua capital, sua dimensão em Km2. Implemente (codifique) uma classe que represente um país conforme os itens abaixo:
Construtor vazio;
Construtor que inicialize o nome, capital e a dimensão do país;
Métodos get/set para seus atributos;
Um método que permita verificar se dois países são iguais. Dois países são iguais se eles tiverem o mesmo nome e a mesma capital.
A assinatura deste método deve ser: public boolean igual (Pais pais).
*/

namespace Pais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pais brasil = new Pais();

            Pais argentina = new Pais("Argentina", "Buenos Aires", 1200);

            Pais estadosUnidos = new Pais();

            if (brasil.Igual(estadosUnidos))
                Console.WriteLine("Países são iguais");
            else
                Console.WriteLine("Países são diferentes");

            Console.ReadLine();
        }
    }
}
