using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Crie uma classe Ponto3D que representa um ponto em um espaço tridimensional, com coordenadas X, Y e Z. Deve conter os seguintes métodos:

-Mostrar, que mostrará as coordenadas do ponto, por exemplo "(3, 5, -2)";
-MoverPara, que mudará as coordenadas do ponto;
-Distancia(Ponto3D p2), que calculará a distância do ponto até outro ponto p2;
*/

namespace Lista1Exercicio04
{
    public class Ponto3D
    {
        // Propriedades
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        // Construtor vazio
        public Ponto3D()
        {
        }

        // Construtor com parâmetros
        public Ponto3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Método Mostrar
        public void Mostrar()
        {
            Console.WriteLine($"({this.x},{this.y},{this.z})");
        }

        // Método MoverPara
        public void MoverPara(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Método Distancia
        public double Distancia(Ponto3D p2)
        {
            return Math.Sqrt(((p2.x - this.x) * (p2.x - this.x)) + ((p2.y - this.y) * (p2.y - this.y)) + ((p2.z - this.z) * (p2.z - this.z)));
        }
    }
}
