using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Uma classe Aluno derivada da classe Pessoa, com um método IrParaEscola;

namespace Lista1Exercicio01
{
    public class Aluno : Pessoa
    {
        // Construtor vazio
        public Aluno()
        {
        }

        // Construtor com parâmetros herdados da classe Pessoa
        public Aluno(string pNome, int pIdade) : base(pNome, pIdade)
        {
        }

        // Método ir para escola
        public void IrParaEscola()
        {
            Console.WriteLine($"O aluno {this.nome} está indo para escola.");
        }
    }
}
