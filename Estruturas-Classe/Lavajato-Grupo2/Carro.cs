using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavajato_Grupo2
{
    internal class Carro : ICarro
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Modelo { get; set; }

        public Carro(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public Carro(int id, string nome, string modelo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Modelo = modelo;
        }
    }
}
