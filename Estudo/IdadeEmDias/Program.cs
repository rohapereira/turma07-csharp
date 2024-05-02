using System;

/*
Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa 
pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.
*/

namespace IdadeEmDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa IdadeEmDias--");

            #region "Nessa solução o usuário entra com as informações de anos, meses e dias de forma manual"
            //Console.Write("\nDigite sua idade em anos: ");
            //int anos = int.Parse(Console.ReadLine());

            //Console.Write("Digite sua idade em meses: ");
            //int meses = int.Parse(Console.ReadLine());

            //Console.Write("Digite sua idade em dias: ");
            //int dias = int.Parse(Console.ReadLine());

            //int idadeEmDias = anos * 360 + meses * 30 + dias;

            //Console.WriteLine($"\nSua idade em dias é: {idadeEmDias} dias");
            #endregion

            #region "Nessa solução o usuário entra com a data de nascimento e o sistema calcula automático sua idade em dias"
            Console.Write("\nDigite sua data de nascimento (no formato dd/mm/aaaa): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            DateTime dataAtual = DateTime.Today;
            TimeSpan diferenca = dataAtual - dataNascimento;
            int idadeEmDias = (int)diferenca.TotalDays;

            Console.WriteLine($"\nSua idade em dias é: {idadeEmDias} dias");
            #endregion

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
