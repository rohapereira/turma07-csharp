using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavajato
{
    internal class Carro : ICarro
    {
        private static int nextId = 0;
        public int Id { get; }
        public string Nome { get; set; }

        public Carro(string nome)
        {
            this.Id = ++nextId;
            this.Nome = nome;
        }

        public Carro()
        {
            this.Id = ++nextId;
            this.Nome = "Não informado";
        }
    }
}
