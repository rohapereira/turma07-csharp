using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1) Escreva um programa orientado a objetos com as seguintes características:

-Uma classe Pessoa, com atributos nome e idade, e métodos Cumprimentar e DizerIdade;
-Uma classe Aluno derivada da classe Pessoa, com um método IrParaEscola;
-Uma classe Professor derivada da classe Pessoa, com um método Explicar que recebe como parâmetro um assunto;
-Na classe principal:
    -Crie uma Pessoa e faça ela Cumprimentar e DizerIdade;
    -Crie um Aluno de 21 anos, e faça ele IrParaEscola, Cumprimentar e DizerIdade;
    -Crie um Professor de 30 anos, e faça ele Cumprimentar, DizerIdade e Explicar sobre um determinado assunto.
*/

namespace Lista1Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Lista1Exercicio01--\n");

            Pessoa pessoa;
            Aluno aluno;
            Professor professor;

            // Primeira parte
            pessoa = new Pessoa("William", 27);
            pessoa.Cumprimentar();
            pessoa.DizerIdade();

            Console.WriteLine();

            // Segunda parte
            aluno = new Aluno("José", 21);
            aluno.IrParaEscola();
            aluno.Cumprimentar();
            aluno.DizerIdade();

            Console.WriteLine();

            // Terceira parte
            professor = new Professor("Marcos", 35);
            professor.Cumprimentar();
            professor.DizerIdade();
            professor.Explicar("programação em C#");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
