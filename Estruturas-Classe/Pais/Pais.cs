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
    internal class Pais
    {
        public string Nome { get; set; } //Propriedade - é o que vai encapsular somente os métodos get e set e ela monta pra mim o atributo.
        public string NomeCapital { get; set; }
        public double DimensaoKm2 { get; set; }

        //método construtor está sobrecarregado (Sobrecarga)
        //Sobrecarga - os métodos tem o mesmo nome com diferentes assinaturas e estão na mesma classe.
        //Assinatura - nome do método + quantidade ou ordem (tipo de dado) de parâmetros.
        public Pais()
        {
        }

        public Pais(string nome, string nomeCapital, double dimensaoKm2)
        {
            this.Nome = nome;
            this.NomeCapital = nomeCapital;
            this.DimensaoKm2 = dimensaoKm2;
        }

        public bool Igual(Pais pais) //Método
        {
            return this.Nome == pais.Nome && this.NomeCapital == pais.NomeCapital;
            //return this == pais;//ERRAAADDDO nesse caso
            //return this.Equals(pais);//ERRAAADDDO nesse caso
        }
    }
}
