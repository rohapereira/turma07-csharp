using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro2
{
    class Carro //objeto carro
    {
        //Principio fundamental da OO => Encapsulamento;

        //public double potencia; //atributos
        //public int numeroDePortas;
        private string cor;
        //private string nome;
        private int velocidade;

        public Carro() //Método contrutor. //Deve ter o mesmo nome da Classe. //Importante: Definir os valores padroes.
        {

        }

        public int NumeroDePortas { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Potencia { get; set; }
        public string Velocidade { get; } //Read only

        public void Acelerar() //métodos
        {
            velocidade++;
        }

        public void Frear()
        {
            velocidade--;
        }

        //public int getVelocidade()
        //{
        //    return velocidade;
        //}

        //public string getNome()
        //{
        //    return nome;
        //}

        //public void setNome(string nome)
        //{
        //    if (nome.Length < 100)
        //        throw new ArgumentException("Número de caracteres de nome foi excedido - máximo 100.");

        //    this.nome = nome;
        //}

        //public string Cor //uma propriedade
        //{
        //    get
        //    {
        //        return this.cor;
        //    }
        //    set
        //    {
        //        this.cor = value;
        //    }
        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //ferrari => objeto (recebe um endereço de memória - heap)
            Carro ferrari = new Carro(); //new => palavra reservada do C# para invocar o método construtor

            Carro carro2 = new Carro();

            List<Carro> carros = new List<Carro>();

            for (int i = 0; i < 3; i++)
            {
                Carro carro = new Carro();
                carros.Add(carro);
            }

            ferrari.Nome = "Ferrari do Zequinha";

            ferrari.Acelerar();
            carro2.Acelerar();

            carros[2].Nome = "Fusca";
            carros[1].Nome = ferrari.Nome;
            carros[2] = carro2;
            carros[2].Nome = "Chevete";

            carros[0].Acelerar();

            //ferrari.velocidade = 70; //encapsulei ele

            Console.WriteLine(ferrari.Velocidade);
            Console.WriteLine($"A velocidade da ferrari é {ferrari.Velocidade}");

            ferrari.Cor = "branca";

            Console.WriteLine(ferrari.Cor);

            carro2.Cor = "laranja";

            //ferrari.Cor
            //carro2.setNome("Paaçklsdjfçqwjkengfçaopnivfgjkqerpoavhjçnaw4mergsfaçklsdjfçqwjkengfçaopnivfgjkqerpoavhjçnaw4mergsfaçklsdjfçqwjkengfçaopnivfgjkqerpoavhjçnaw4mergsfaçklsdjfçqwjkengfçaopnivfgjkqerpoavhjçnaw4mergsflio");


            ferrari.NumeroDePortas = 2;

            Console.WriteLine(ferrari.NumeroDePortas);
        }
    }
}
