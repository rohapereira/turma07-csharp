using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sobre Pilha: A estrutura de pilha é do tipo LIFO (Last in, First out), ou seja, o último elemento a ser inserido na pilha, será o primeiro a ser retirado. Assim, uma pilha permite acesso a apenas um item de dados - o último inserido. Para processar o penúltimo item inserido, deve-se remover o último.

            Stack<int> pilha1 = new Stack<int>();
            pilha1.Push(1);
            pilha1.Push(8);
            pilha1.Push(9);
            pilha1.Push(-80);

            int x = pilha1.ElementAt(0); //na pilha permite apenas visualizar o item da posição
            int y = pilha1.Pop(); //retira o último item que entrou na pilha

            List<int> lista = new List<int>();
            lista.Insert(0, 1);
            lista.Insert(0, 8);
            lista.Insert(0, 9);
            lista.Insert(0, -80);

            lista.RemoveAt(0);
        }
    }
}
