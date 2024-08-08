using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade
{
    internal class Aluno
    {
        // Propriedades
        public int Codigo { get; }
        public string Nome { get; set; }
        public string Curso { get; set; }

        // Método construtor vazio
        public Aluno(int codigo)
        {
            this.Codigo = codigo;
        }

        // Método ImprimirAluno
        public void ImprimirAluno()
        {
            Console.WriteLine("***Dados do Aluno***");
            Console.WriteLine($"Código = {Codigo} \nNome = {Nome} \nCurso: {Curso}");
        }
    }
}
